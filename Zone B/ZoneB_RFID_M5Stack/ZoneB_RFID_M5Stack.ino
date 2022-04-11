#include <SPI.h>
#include <MFRC522.h>
#include <M5Stack.h>

// Entrées des pins du RC522
#define SS_PIN 10
#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN);

// Initialisation de la variable où l'UID du badge sera stocké
byte nuidPICC[4];

void setup(){
  M5.begin();
  M5.Power.begin();
  Serial.begin(9600);
  SPI.begin(); 
  rfid.PCD_Init(); 
  Serial.println("Scan de tag RFID...");
  M5.Lcd.println("En attente d'un badge...");
}

void loop(){
  readRFID();
  delay(200);
}

void readRFID(){
  // On regarde si une nouvelle carte est detectée
  if ( ! rfid.PICC_IsNewCardPresent())
  return;
 
  // On vérifie si le badge  bien été lu
  if (  !rfid.PICC_ReadCardSerial())
  return;
 
  if (rfid.uid.uidByte[0] != nuidPICC[0] ||
  rfid.uid.uidByte[1] != nuidPICC[1] ||
  rfid.uid.uidByte[2] != nuidPICC[2] ||
  rfid.uid.uidByte[3] != nuidPICC[3] ){
  Serial.println("Une nouvelle carte a bien été detectée !");
  M5.Lcd.println("Une nouvelle carte a été detectée !");
  
  // On stocke l'UID du badge dans le tableau
  for (byte i = 0; i < 4; i++){
    nuidPICC[i] = rfid.uid.uidByte[i];
  }
  
  Serial.print("UID du badge: ");
  M5.Lcd.print("UID du badge: ");
  printDec(rfid.uid.uidByte, rfid.uid.size);
  Serial.println();
  M5.Lcd.println();
  }
  
  // Arrêter le PICC
  rfid.PICC_HaltA();
  // On stop le cryptage sur PCD
  rfid.PCD_StopCrypto1();
}

void printDec(byte *buffer, byte bufferSize){
  for (byte i = 0; i < bufferSize; i++){
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    M5.Lcd.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], DEC);
    M5.Lcd.print(buffer[i], DEC);
  }
}
