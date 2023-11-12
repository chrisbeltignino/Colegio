#include <Servo.h>
int buttonpin = 2;
Servo myservo;
int buttonState = 0;
boolean state;

void setup() {
  pinMode(buttonpin, INPUT);
  myservo.attach(9);
}
void loop(){
  buttonState = digitalRead(buttonpin);

  if (buttonState==HIGH){
    if(state==false){
      state=true;
    }
    else{
      state=false;
     
    }
  }
  if (state=true){
    myservo.write(60);
  }
  else{
myservo.write(120);
  }
}
