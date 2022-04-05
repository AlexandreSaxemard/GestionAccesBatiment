#include <MFRC522.h> // pour le RFID
#include <SPI.h> // pour le RFID and le module de carte SD
#include <SD.h> // pour la carte SD 
#include <RTClib.h> // pour le RTC
#include <WiFi.h>
#include "PubSubClient.h"

// Configuration du réseau WIFI
const char* ssid = "LPiOTIA";
const char* password = "";

static const char* connectionString = "";

const char* mqtt_server = "192.168.43.XX";
const char* badge_topic = "Arduino/ZoneB";

const char* clientID = "Arduino_ZoneB";

WiFiClient wifiClient;
PubSubClient client(mqtt_server, 1883, wifiClient);

// definition des pins pour le RFID
#define CS_RFID 10
#define RST_RFID 9

// definition du pin selectionne pour le module de la carte SD
#define CS_SD 4 

// Creation d'un fichier pour stocker les donnees
//File myFile;

// On instancie la classe du RFID
MFRC522 rfid(CS_RFID, RST_RFID); 

// Variable pour stocker l'UID du tag
String uidString;

// On instancie la classe du RTC
RTC_DS1307 rtc;

// Definition de l'heure du badgage
const int checkInHour = 9;
const int checkInMinute = 5;

// Variable pour stocker l'eregistrement de l'utilisateur
int userCheckInHour;
int userCheckInMinute;

// Pins pour les leds et le buzzer
const int redLED = 6;
const int greenLED = 7;
const int buzzer = 5;

void setup() {
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
  
  // Definition des leds et du buzzer comme sortie
  pinMode(redLED, OUTPUT);  
  pinMode(greenLED, OUTPUT);
  pinMode(buzzer, OUTPUT);
  
  // Initialisation du port serie
  Serial.begin(9600);
  while(!Serial); 
  
  // Initialisation du bus SPI
  SPI.begin(); 
  
  // Initialisation du MFRC522 
  rfid.PCD_Init(); 
  
  // Configuration de la carte SD
  Serial.print("Initialisation de la carte SD...");
  if(!SD.begin(CS_SD)) {
    Serial.println("Erreur d'initialisation !");
    return;
  }
  Serial.println("Initialisation effectuée !");
  
  // Configuration du RTC  
  if(!rtc.begin()) {
    Serial.println("RTC non trouvé");
    while(1);
  }
  else {
    // La ligne suivante définit le RTC sur la date et l'heure à laquelle ce code a été compilé
    rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
  }
  if(!rtc.isrunning()) {
    Serial.println("RTC n'est pas en marche !");
  }
}

void readRFID() {
  rfid.PICC_ReadCardSerial();
  Serial.print("UID du Tag RFID passé: ");
  uidString = String(rfid.uid.uidByte[0]) + " " + String(rfid.uid.uidByte[1]) + " " + 
    String(rfid.uid.uidByte[2]) + " " + String(rfid.uid.uidByte[3]);
  Serial.println(uidString);
 
  // Son du buzzer quand le badge est passé
  tone(buzzer, 2000); 
  delay(100);        
  noTone(buzzer);
  
  delay(100);
}

void logCard() {
  // Active la broche de selection de la puce de la carte SD
  //digitalWrite(CS_SD,LOW);
  
  // Ouverture du ficher
  //myFile=SD.open("TagRFID.txt", FILE_WRITE);
  
  // Si le fichier est bien ouvert, on ecrit dedans
  /*if (myFile) {
    Serial.println("Fichier ouvert avec succès !");
    myFile.print(uidString);
    myFile.print(", ");*/
    
    // Sauvergarde du temps dans la carte SD
    DateTime now = rtc.now();
    /*myFile.print(now.year(), DEC);
    myFile.print('/');
    myFile.print(now.month(), DEC);
    myFile.print('/');
    myFile.print(now.day(), DEC);
    myFile.print(',');
    myFile.print(now.hour(), DEC);
    myFile.print(':');
    myFile.println(now.minute(), DEC);*/
    
    // Ecriture du temps dans le moniteur serie
    Serial.print(now.year(), DEC);
    Serial.print('/');
    Serial.print(now.month(), DEC);
    Serial.print('/');
    Serial.print(now.day(), DEC);
    Serial.print(' ');
    Serial.print(now.hour(), DEC);
    Serial.print(':');
    Serial.println(now.minute(), DEC);
    Serial.println("L'écriture dans la carte SD a bien été effectuée !");
    //myFile.close();
    
    // Sauvegarde du temps d'enregistrement;
    userCheckInHour = now.hour();
    userCheckInMinute = now.minute();
  }
  else {
    Serial.println("Erreur d'ouverture du fichier TagRFID.txt");  
  }
  // Désactive la broche de sélection de la puce de la carte SD  
  //digitalWrite(CS_SD,HIGH);
}
void verifyCheckIn(){
  if((userCheckInHour < checkInHour)||((userCheckInHour==checkInHour) && (userCheckInMinute <= checkInMinute))){
    digitalWrite(greenLED, HIGH);
    delay(2000);
    digitalWrite(greenLED,LOW);
    Serial.println("Bienvenue !");
  }
  else{
    digitalWrite(redLED, HIGH);
    delay(2000);
    digitalWrite(redLED,LOW);
    Serial.println("Vous êtes en retard...");
  }
}

void loop() {
  Serial.println("Début de l'envoi des données...");
  // Recherche de nouvelles cartes
  if(rfid.PICC_IsNewCardPresent()) {
    readRFID();
    logCard();
    verifyCheckIn();
  }
  if(client.publish(badge_topic, String(uidString))){
    Serial.println("UID du badge passé au lecteur envoyé !"); 
  }
  delay(10);
}
