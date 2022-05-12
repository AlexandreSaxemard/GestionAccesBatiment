#include <BLEDevice.h>
#include <BLEUtils.h>
#include <BLEScan.h>
#include <BLEAdvertisedDevice.h>
#include <SPI.h>
#include "PubSubClient.h"
#include <WiFi.h>

// Configuration du réseau WIFI
const char* ssid = "LPiOTIA";
const char* password = "";

static const char* connectionString = "";

const char* mqtt_server = "192.168.143.151";
const char* badge_topic = "Campus";

const char* clientID = "ZoneA";

WiFiClient wifiClient;
PubSubClient client(mqtt_server, 1883, wifiClient);

int scanTime = 10; //En secondes
BLEScan* pBLEScan;

class MyAdvertisedDeviceCallbacks: public BLEAdvertisedDeviceCallbacks {
    void onResult(BLEAdvertisedDevice advertisedDevice) {
      Serial.printf("Advertised Device: %s \n", advertisedDevice.toString().c_str());
    }
};

void setup() {
  Serial.begin(115200);
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
  
  Serial.println("Scanning...");

  BLEDevice::init("");
  pBLEScan = BLEDevice::getScan(); //Creer un nouveau scan
  pBLEScan->setAdvertisedDeviceCallbacks(new MyAdvertisedDeviceCallbacks());
  pBLEScan->setActiveScan(true); 
  pBLEScan->setInterval(100);
  pBLEScan->setWindow(99);  // 
}

void loop() {
  // A faire en boucle
  BLEScanResults foundDevices = pBLEScan->start(scanTime, false);
  for(int i = 0; i < foundDevices.getCount(); i++){
    client.publish(badge_topic, foundDevices.getDevice(i).getAddress().toString().c_str());
  }
  Serial.print("Devices found: ");
  Serial.println(foundDevices.getCount());
  Serial.println("Scan done!");
  pBLEScan->clearResults();   // effacer les resultats de BLEScan pour liberer de la mémoire
  delay(30000);
}
