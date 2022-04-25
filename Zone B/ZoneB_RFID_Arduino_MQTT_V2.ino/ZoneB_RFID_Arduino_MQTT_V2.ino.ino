#include <ESP8266WiFi.h>
#include <SPI.h>
#include <MFRC522.h>
#include <WiFiClient.h>
#include "PubSubClient.h"

// Configuration du réseau WIFI
const char* ssid = "AZUR INFO";
const char* password = "0918273645";

static const char* connectionString = "";

const char* mqtt_server = "172.24.102.120";
const char* badge_topic = "Arduino/Test2";

const char* clientID = "Arduino_ZoneB";

WiFiClient wifiClient;
PubSubClient client(mqtt_server, 1883, wifiClient);

// Entrées des pins du RC522
#define SS_PIN D8
#define RST_PIN D3

MFRC522 rfid(SS_PIN, RST_PIN); 
MFRC522::MIFARE_Key key;

String tag;

void setup() {
  Serial.begin(9600);
  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522
  Serial.println("Tentative de connexion au WiFi...");

  delay(1000);

  WiFi.begin(ssid, password);
  while(WiFi.status() != WL_CONNECTED){
    delay(500);
    Serial.print(".");
  }
  Serial.println("Connexion au WiFi effectuée avec succès !");
  Serial.println("Adresse IP: ");
  Serial.println(WiFi.localIP());

  if(client.connect(clientID)){
    Serial.println("Connexion au Broker MQTT effectuée avec succès !");
  }else{
    Serial.println("Connexion au Broker MQTT échouée...");
  }
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
    tag = "";

    client.publish(badge_topic, (byte*) &nuidPICC, sizeof(nuidPICC));
    Serial.println("UID du badge envoyé!");
  
    rfid.PICC_HaltA();
    rfid.PCD_StopCrypto1();
  }
}
