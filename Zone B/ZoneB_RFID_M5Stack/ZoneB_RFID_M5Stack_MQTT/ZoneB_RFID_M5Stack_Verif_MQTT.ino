#include <SPI.h>
#include <MFRC522.h>
#include <M5Stack.h>

// Entrées des pins du RC522
#define SS_PIN 10
#define RST_PIN 9

MFRC522 rfid(SS_PIN, RST_PIN);   

void setup(){
  M5.begin();
  M5.Power.begin();
  SPI.begin();     
  rfid.PCD_Init();   
  Serial.begin(9600);
  Serial.println("Scan de tag RFID...");
  M5.Lcd.println("En attente d'un badge...");
}

void loop(){
  if ( ! rfid.PICC_IsNewCardPresent()) 
  {
    return;
  }

  if ( ! rfid.PICC_ReadCardSerial()) 
  {
    return;
  }
  Serial.println("UID du badge: ");
  M5.Lcd.println("UID du badge: ");
  
  String content= "";
  byte letter;
  
  for (byte i = 0; i < rfid.uid.size; i++){
    Serial.println(rfid.uid.uidByte[i] < 0x10 ? " 0" : " ");
    Serial.println(rfid.uid.uidByte[i], HEX);
    content.concat(String(rfid.uid.uidByte[i] < 0x10 ? " 0" : " "));
    content.concat(String(rfid.uid.uidByte[i], HEX));
    M5.Lcd.println(rfid.uid.uidByte[i] < 0x10 ? " 0" : " ");
    M5.Lcd.println(rfid.uid.uidByte[i], HEX);
    content.concat(String(rfid.uid.uidByte[i] < 0x10 ? " 0" : " "));
    content.concat(String(rfid.uid.uidByte[i], HEX));
  }
  Serial.println("Message : ");
  M5.Lcd.println("Message : ");
  
  content.toUpperCase();
  if (content.substring(1) == "59 64 CC 48"){ //Plz change to your cards UID
    Serial.println("Autorisé !");
    M5.Lcd.println("Autorisé !");
    delay(3000);
    setup();
  }
 
  else{
    Serial.println("Accès refusé !");
    M5.Lcd.println("Accès refusé !");
    delay(3000);
    setup();
  }
} 
