int led=3;

void fadeIn(int pin, int tiempo)
{
  int i;
for(i=0;i<256;i++)
{
analogWrite(led,i);
delay(15);
}
}

void setup() {
  // put your setup code here, to run once:
pinMode(led,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
fadeIn(led,15);
for(i=255;i>=0;i--)
{
  analogWrite(led,i);
  delay(15);
}
delay(1000);
}
