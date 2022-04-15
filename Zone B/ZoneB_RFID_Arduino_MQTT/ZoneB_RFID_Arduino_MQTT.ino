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

// Initialisation de la variable où l'UID du badge sera stocké
byte nuidPICC[4];

void setup(){
  Serial.begin(115200);
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

  SPI.begin(); 
  rfid.PCD_Init(); 
  Serial.println("Scan de tag RFID...");
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
  
  // On stocke l'UID du badge dans le tableau
  for (byte i = 0; i < 4; i++){
    nuidPICC[i] = rfid.uid.uidByte[i];
  }
  
  Serial.print("UID du badge: ");
  for (byte i = 0; i < 4; i++) 
  {
    //Serial.print(nuidPICC[i], HEX);
    Serial.print(" ");
  }
  printDec(rfid.uid.uidByte, rfid.uid.size);
  Serial.println();
  }

  client.publish(badge_topic, (byte*) &nuidPICC, sizeof(nuidPICC));
  Serial.println("UID du badge envoyé!");
 
  // Arrêter le PICC
  rfid.PICC_HaltA();
  // On stop le cryptage sur PCD
  rfid.PCD_StopCrypto1();
}


void loop() 
{ 
  readRFID();
  /*if(client.publish(badge_topic, (byte*) &nuidPICC, sizeof(nuidPICC))){
    Serial.println("UID du badge envoyé!");
  }*/
}

void printDec(byte *buffer, byte bufferSize) {
 for (byte i = 0; i < bufferSize; i++) {
   Serial.print(buffer[i] < 0x10 ? " 0" : " ");
   Serial.print(buffer[i], DEC);
 }
}
