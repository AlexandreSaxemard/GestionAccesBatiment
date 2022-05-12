#include <SPI.h>
#include <MFRC522.h>

// Entrées des pins du RC522

#define SS_PIN 10
#define RST_PIN 3

#define serrure_PIN 6

MFRC522 rfid(SS_PIN, RST_PIN);
MFRC522::MIFARE_Key key;
String tag;

//String tagUID;

void setup() {

Serial.begin(115200);

SPI.begin(); // Init SPI bus

rfid.PCD_Init(); // Init MFRC522

pinMode(serrure_PIN, OUTPUT);

digitalWrite(serrure_PIN, HIGH);

delay(5000);

digitalWrite(serrure_PIN, LOW);

Serial.println("Scan de tag RFID...");

}

void loop() {

if ( ! rfid.PICC_IsNewCardPresent())

return;

if (rfid.PICC_ReadCardSerial()) {

Serial.println("Une nouvelle carte a bien été detectée !");
 for (byte i = 0; i < 4; i++) {

tag += rfid.uid.uidByte[i];

}

Serial.println("UID du badge: ");

Serial.println(tag);

digitalWrite(serrure_PIN, HIGH);

delay(5000);

digitalWrite(serrure_PIN, LOW);


tag = "";

 rfid.PICC_HaltA();

 rfid.PCD_StopCrypto1();

 }

 }
