#include <Servo.h> //Importamos la biblioteca Servo.h
#include <Arduino.h> 
Servo barrera; 
int pulsador = 2;
int valorPulsador = 0;
int valor = 0;

void setup() {
 barrera.attach(9);
  pinMode(pulsador, INPUT); 
}

void loop() {
  valorPulsador = digitalRead(pulsador);
  if(valorPulsador == HIGH && valor == 0){
    barrera.write(100);
    valor = 1;
  }
  else{
    valor==0;
    }
  if(valorPulsador == LOW && valor == 1){
    barrera.write(0);
    valor = 0;
  }
  

}
