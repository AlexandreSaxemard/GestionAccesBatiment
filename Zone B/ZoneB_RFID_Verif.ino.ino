//All Credit Technic 1510
//
//
//
//
#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 10
#define RST_PIN 9
MFRC522 rfid(SS_PIN, RST_PIN);   


 
void setup() 
{
  
  SPI.begin();     
  rfid.PCD_Init();   
  Serial.begin(9600);
  Serial.println("Scan RFID Card");
  

}
void loop() 
{

  if ( ! rfid.PICC_IsNewCardPresent()) 
  {
    return;
  }

  if ( ! rfid.PICC_ReadCardSerial()) 
  {
    return;
  }

  Serial.println("UID tag :");
  String content= "";
  byte letter;
  for (byte i = 0; i < rfid.uid.size; i++) 
  {
     Serial.println(rfid.uid.uidByte[i] < 0x10 ? " 0" : " ");
     Serial.println(rfid.uid.uidByte[i], HEX);
     content.concat(String(rfid.uid.uidByte[i] < 0x10 ? " 0" : " "));
     content.concat(String(rfid.uid.uidByte[i], HEX));
  }
 Serial.println("Message : ");
 content.toUpperCase();
  if (content.substring(1) == "59 64 CC 48") //Plz change to your cards UID
  {
    Serial.println("Authorized");

    delay(3000);
    setup();
  }
 
 else   {
    Serial.println(" Access denied");
    delay(3000);
      setup();
      }
} 
