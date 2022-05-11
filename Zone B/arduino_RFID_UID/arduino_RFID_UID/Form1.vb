Imports MySql.Data.MySqlClient

Public Class Form1

    Dim Connection As New MySqlConnection("server=localhost; user=root; password=''; database=arduino_rfid_ui")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable
    Dim Table_Name As String = "client" 'nom de la table
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Enregistrer"
    Dim SqlCmdSearchstr As String

    Public Shared StrSerialIn As String
    Dim GetID As Boolean = False
    Dim ViewUserData As Boolean = False
    Private TextBoxDepartment As Object
    Private PictureBoxStatusConnect As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelConnection.Visible = True
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        ComboBoxBaudRate.SelectedIndex = 3
    End Sub

    Private Sub InterfaceClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PanelConnection.Visible = True
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        ComboBoxBaudRate.SelectedIndex = 3
    End Sub

    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT id, nom, adresse, ville, departement, photo FROM " & Table_Name & " ORDER BY nom"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT
                    DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.ClearSelection()
                Else
                    DataGridView1.DataSource = DT
                End If
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT photo FROM " & Table_Name & " WHERE id LIKE '" & IDRam & "'"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("photo")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImagePreview.Image = Image.FromStream(lmgStr)
                    PictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()
                End If
                LoadImagesStr = False
            End If
        Catch ex As Exception
            MsgBox("Impossible de charger la base de données !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ShowDataUser()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE id LIKE '" & LabelID.Text.Substring(5, LabelID.Text.Length - 5) & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                Dim ImgArray() As Byte = DT.Rows(0).Item("photo")
                Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                PictureBoxUserImage.Image = Image.FromStream(lmgStr)
                lmgStr.Close()

                LabelID.Text = "ID : " & DT.Rows(0).Item("id")
                LabelName.Text = DT.Rows(0).Item("nom")
                LabelAddress.Text = DT.Rows(0).Item("adresse")
                LabelCity.Text = DT.Rows(0).Item("ville")
                LabelDepartment.Text = DT.Rows(0).Item("departement")
            Else
                MsgBox("ID non trouvé !!!" & vbCr & "Veuillez enregistrer votre pièce d'identité.", MsgBoxStyle.Information, "Message d'informations")
            End If
        Catch ex As Exception
            MsgBox("Impossible de charger la base de données !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    Private Sub ClearInputUpdateData()
        TextBoxNom.Text = ""
        LabelGetID.Text = "________"
        TextBoxadresse.Text = ""
        TextBoxVille.Text = ""
        TextBoxDep.Text = ""
        PictureBoxImageInput.Image = My.Resources.tele
    End Sub

    Private Sub buttonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        PictureBoxSelect.Top = ButtonConnection.Top
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = False
        PanelConnection.Visible = True
    End Sub

    Private Sub buttonUserData_Click(sender As Object, e As EventArgs) Handles ButtonUserData.Click
        If TimerSerialIn.Enabled = False Then
            MsgBox("Impossible d'ouvrir les données des utilisateurs !!!" & vbCr & "Cliquez sur le menu Connexion, puis sur le bouton Connexion.", MsgBoxStyle.Information, "Information")
            Return
        Else
            StrSerialIn = ""
            ViewUserData = True
            PictureBoxSelect.Top = ButtonUserData.Top
            PanelRegistrationandEditUserData.Visible = False
            PanelConnection.Visible = False
            PanelUserData.Visible = True
        End If
    End Sub

    Private Sub buttonRegistration_Click(sender As Object, e As EventArgs) Handles ButtonRegistration.Click
        StrSerialIn = ""
        ViewUserData = False
        PictureBoxSelect.Top = ButtonRegistration.Top
        PanelConnection.Visible = False
        PanelUserData.Visible = False
        PanelRegistrationandEditUserData.Visible = True
        ShowData()
    End Sub

    Private Sub PanelConnection_Paint(sender As Object, e As PaintEventArgs) Handles PanelConnection.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelConnection.ClientRectangle)
    End Sub

    Private Sub PanelConnection_Resize(sender As Object, e As EventArgs) Handles PanelConnection.Resize
        PanelConnection.Invalidate()
    End Sub

    Private Sub PanelUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelUserData.ClientRectangle)
    End Sub

    Private Sub PanelUserData_Resize(sender As Object, e As EventArgs) Handles PanelUserData.Resize
        PanelUserData.Invalidate()
    End Sub

    Private Sub PanelRegistrationandEditUserData_Paint(sender As Object, e As PaintEventArgs) Handles PanelRegistrationandEditUserData.Paint
        e.Graphics.DrawRectangle(New Pen(Color.LightGray, 2), PanelRegistrationandEditUserData.ClientRectangle)
    End Sub

    Private Sub PanelRegistrationandEditUserData_Resize(sender As Object, e As EventArgs) Handles PanelRegistrationandEditUserData.Resize
        PanelRegistrationandEditUserData.Invalidate()
    End Sub

    Private Sub buttonScanPort_Click(sender As Object, e As EventArgs) Handles buttonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Port Com non détecté", MsgBoxStyle.Critical, "Message d'erreur")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub buttonScanPort_MouseHover(sender As Object, e As EventArgs) Handles buttonScanPort.MouseHover
        buttonScanPort.ForeColor = Color.White
    End Sub

    Private Sub buttonScanPort_MouseLeave(sender As Object, e As EventArgs) Handles buttonScanPort.MouseLeave
        buttonScanPort.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub buttonConnect_Click(sender As Object, e As EventArgs) Handles buttonConnect.Click
        If buttonConnect.Text = "Connecté" Then
            SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
            SerialPort1.PortName = ComboBoxPort.SelectedItem
            Try
                SerialPort1.Open()
                TimerSerialIn.Start()
                buttonConnect.Text = "Déconnecté"
                PictureBox1.Image = My.Resources.Connected
            Catch ex As Exception
                MsgBox("Connexion échouée !!!" & vbCr & "Arduino n'est pas détecter.", MsgBoxStyle.Critical, "Message d'erreur")
                PictureBoxStatusConnect.Image = My.Resources.Disconnect
            End Try
        ElseIf buttonConnect.Text = "Déconnecté" Then
            PictureBox1.Image = My.Resources.Disconnect
            buttonConnect.Text = "Connecté"
            LabelConnectionStatus.Text = "Etat de connexion : Déconnecté"
            TimerSerialIn.Stop()
            SerialPort1.Close()
        End If
    End Sub

    Private Sub ButtonConnect_MouseHover(sender As Object, e As EventArgs) Handles buttonConnect.MouseHover
        buttonConnect.ForeColor = Color.White
    End Sub

    Private Sub ButtonConnect_MouseLeave(sender As Object, e As EventArgs) Handles buttonConnect.MouseLeave
        buttonConnect.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub buttonClear_Click(sender As Object, e As EventArgs) Handles buttonClear.Click
        LabelID.Text = "ID : ________"
        LabelName.Text = "Patientez..."
        LabelAddress.Text = "Patientez..."
        LabelCity.Text = "Patientez..."
        LabelDepartment.Text = "Patientez..."
        PictureBoxUserImage.Image = Nothing
    End Sub

    Private Sub buttonClear_MouseHover(sender As Object, e As EventArgs) Handles buttonClear.MouseHover
        buttonClear.ForeColor = Color.White
    End Sub

    Private Sub buttonClear_MouseLeave(sender As Object, e As EventArgs) Handles buttonClear.MouseLeave
        buttonClear.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte

        If TextBoxNom.Text = "" Then
            MessageBox.Show("Nom ne doit pas etre vide !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxadresse.Text = "" Then
            MessageBox.Show("Adresse ne doit pas etre vide !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxVille.Text = "" Then
            MessageBox.Show("Ville ne doit pas etre vide !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxDep.Text = "" Then
            MessageBox.Show("Département ne doit pas etre vide !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If StatusInput = "Enregistrer" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
            Else
                MessageBox.Show("Sélectionner l'image !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (id, nom, adresse, ville, departement, photo) VALUES (@id, @nom, @adresse, @ville, @departement, @photo)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                    .Parameters.AddWithValue("@id", LabelGetID.Text)
                    .Parameters.AddWithValue("@adresse", TextBoxadresse.Text)
                    .Parameters.AddWithValue("@ville", TextBoxVille.Text)
                    .Parameters.AddWithValue("@departement", TextBoxDep.Text)
                    .Parameters.AddWithValue("@photo", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("Données sauvegardées avec succès", MsgBoxStyle.Information, "Information")
                IMG_FileNameInput = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Les données n'ont pas été sauvegardées !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message dùerreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  id=@id,nom=@nom,adresse=@adresse,ville=@ville,departement=@departement,photo=@photo WHERE id=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                        .Parameters.AddWithValue("@id", LabelGetID.Text)
                        .Parameters.AddWithValue("@adresse", TextBoxadresse.Text)
                        .Parameters.AddWithValue("@ville", TextBoxVille.Text)
                        .Parameters.AddWithValue("@departement", TextBoxDep.Text)
                        .Parameters.AddWithValue("@photo", arrImage)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Données mises à jour avec succès", MsgBoxStyle.Information, "Information")
                    IMG_FileNameInput = ""
                    buttonSave.Text = "Enregistrer"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Les données n'ont pas été mises à jour !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()

            Else

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  id=@id,nom=@nom,adresse=@adresse,ville=@ville,departement=@departement WHERE id=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                        .Parameters.AddWithValue("@id", LabelGetID.Text)
                        .Parameters.AddWithValue("@adresse", TextBoxadresse.Text)
                        .Parameters.AddWithValue("@ville", TextBoxVille.Text)
                        .Parameters.AddWithValue("@departement", TextBoxDep.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Données mises à jour avec succès", MsgBoxStyle.Information, "Information")
                    buttonSave.Text = "Enregistrer"
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Les données n'ont pas été mises à jour !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Enregistrer"
        End If
        PictureBoxImagePreview.Image = Nothing
        ShowData()
    End Sub

    Private Sub buttonSave_MouseHover(sender As Object, e As EventArgs) Handles buttonSave.MouseHover
        buttonSave.ForeColor = Color.White
    End Sub

    Private Sub buttonSave_MouseLeave(sender As Object, e As EventArgs) Handles buttonSave.MouseLeave
        buttonSave.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub buttonClearForm_Click(sender As Object, e As EventArgs) Handles buttonClearForm.Click
        ClearInputUpdateData()
    End Sub

    Private Sub buttonClearForm_MouseHover(sender As Object, e As EventArgs) Handles buttonClearForm.MouseHover
        buttonClearForm.ForeColor = Color.White
    End Sub

    Private Sub buttonClearForm_MouseLeave(sender As Object, e As EventArgs) Handles buttonClearForm.MouseLeave
        buttonClearForm.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub buttonScanID_Click(sender As Object, e As EventArgs) Handles buttonScanID.Click
        If TimerSerialIn.Enabled = True Then
            PanelReadingTagProcess.Visible = True
            GetID = True
            buttonScanID.Enabled = False
        Else
            MsgBox("Impossible d'ouvrir les données des utilisateurs !!!" & vbCr & "Cliquez sur le menu Connexion, puis sur le bouton Connexion.", MsgBoxStyle.Critical, "Message d'erreur")
        End If
    End Sub


    Private Sub buttonScanID_MouseHover(sender As Object, e As EventArgs) Handles buttonScanID.MouseHover
        buttonScanID.ForeColor = Color.White
    End Sub

    Private Sub buttonScanID_MouseLeave(sender As Object, e As EventArgs) Handles buttonScanID.MouseLeave
        buttonScanID.ForeColor = Color.FromArgb(6, 71, 165)
    End Sub

    Private Sub PictureBoxImageInput_Click(sender As Object, e As EventArgs) Handles PictureBoxImageInput.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxImageInput.ImageLocation = IMG_FileNameInput
        End If


    End Sub

    Private Sub CheckBoxByName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
        End If
        If CheckBoxByName.Checked = False Then
            CheckBoxByID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
        If CheckBoxByID.Checked = False Then
            CheckBoxByName.Checked = True
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT id, adresse, nom, ville, departement FROM " & Table_Name & " ORDER BY nom"
            Else
                SqlCmdSearchstr = "SELECT id, adresse, nom, ville, departement FROM " & Table_Name & " WHERE id LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT id, adresse, nom, ville, departement FROM " & Table_Name & " ORDER BY nom"
            Else
                SqlCmdSearchstr = "SELECT id, adresse, nom, ville, departement FROM " & Table_Name & " WHERE nom LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("La recherche a échoué." & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub DataGridView1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            IDRam = .Rows(i).Cells("id").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub TimerTimeDate_Tick(sender As Object, e As EventArgs) Handles TimerTimeDate.Tick
        Label1DateTime.Text = "Time " & DateTime.Now.ToString("HH:mm:ss") & "  Date " & DateTime.Now.ToString("dd MMM, yyyy")
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("Impossible de supprimer, les données de la table sont vides", MsgBoxStyle.Critical, "Message d'erreur")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Impossible à supprimer, sélectionnez les données de la table à supprimer.", MsgBoxStyle.Critical, "Message d'erreur")
            Return
        End If

        If MsgBox("Supprimer l'enregistrement ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connexion échouée !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE id='" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("La suppression a échoué." & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            Connection.Close()
        End Try
        PictureBoxImagePreview.Image = Nothing
        Connection.Close()
        ShowData()
    End Sub

    Private Sub SelectionnerToutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectionnerToutToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub

    Private Sub EffacerSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EffacerSelectionToolStripMenuItem.Click
        DataGridView1.ClearSelection()
        PictureBoxImagePreview.Image = Nothing
    End Sub

    Private Sub RafraîchirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RafraîchirToolStripMenuItem.Click
        ShowData()
    End Sub

    Private Sub TimerSerialIn_Tick(sender As Object, e As EventArgs) Handles TimerSerialIn.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            LabelConnectionStatus.Text = "Etat de connexion : Connecté"
            If StrSerialIn <> "" Then
                If GetID = True Then
                    LabelGetID.Text = StrSerialIn
                    GetID = False
                    If LabelGetID.Text <> "________" Then
                        PanelReadingTagProcess.Visible = False
                        IDCheck()
                    End If
                End If
                If ViewUserData = True Then
                    ViewData()
                End If
            End If
        Catch ex As Exception
            TimerSerialIn.Stop()
            SerialPort1.Close()
            LabelConnectionStatus.Text = "Etat de connexion : Déconnecté"
            PictureBox1.Image = My.Resources.Disconnect
            MsgBox("Échec de la connexion !!!" & vbCr & "Arduino n'est pas détecté.", MsgBoxStyle.Critical, "Message d'erreur")
            buttonConnect_Click(sender, e)
            Return
        End Try

        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
        ElseIf PictureBox1.Visible = False Then
            PictureBox1.Visible = True
        End If
    End Sub


    Private Sub IDCheck()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Échec de la connexion !!!" & vbCrLf & "Veuillez vérifier que le serveur est prêt !!!", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT * FROM " & Table_Name & " WHERE id LIKE '" & LabelGetID.Text & "'"
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                If MsgBox("ID enregistrée !" & vbCr & "Vous souhaitez modifier les données ?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then
                    DT = Nothing
                    Connection.Close()
                    buttonScanID.Enabled = True
                    GetID = False
                    LabelGetID.Text = "________"
                    Return
                Else
                    Dim ImgArray() As Byte = DT.Rows(0).Item("photo")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImageInput.Image = Image.FromStream(lmgStr)
                    PictureBoxImageInput.SizeMode = PictureBoxSizeMode.Zoom

                    TextBoxNom.Text = DT.Rows(0).Item("nom")
                    TextBoxadresse.Text = DT.Rows(0).Item("adresse")
                    TextBoxVille.Text = DT.Rows(0).Item("ville")
                    TextBoxDep.Text = DT.Rows(0).Item("departement")
                    StatusInput = "Mettre à jour"
                End If
            End If
        Catch ex As Exception
            MsgBox("Impossible de charger la base de données !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()

        buttonScanID.Enabled = True
        GetID = False
    End Sub

    Private Sub ViewData()
        LabelID.Text = "ID : " & StrSerialIn
        If LabelID.Text = "ID : ________" Then
            ViewData()
        Else
            ShowDataUser()
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        GroupBoxImage.Location = New Point((PanelUserData.Width / 2) - (GroupBoxImage.Width / 2), GroupBoxImage.Top)
        PanelReadingTagProcess.Location = New Point((PanelRegistrationandEditUserData.Width / 2) - (PanelReadingTagProcess.Width / 2), 106)
    End Sub

    Private Sub buttonCloseReadingTag_Click(sender As Object, e As EventArgs) Handles buttonCloseReadingTag.Click
        PanelReadingTagProcess.Visible = False
        buttonScanID.Enabled = True
    End Sub
End Class