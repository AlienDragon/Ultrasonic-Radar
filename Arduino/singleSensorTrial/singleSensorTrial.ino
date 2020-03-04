#include <Servo.h>

Servo SensorServo;
byte sectionCounter = 0;

void setup()
{
  Serial.begin(115200);
  SensorServo.attach(2);
  SensorServo.write(0);
  pinMode(9, OUTPUT);
  pinMode(10, INPUT);
}

void loop()
{
  while (sectionCounter < 17)
  {
    sectionCounter ++;
    measure();
  }
  while (sectionCounter > 0)
  {
    sectionCounter --;
    measure();
  }
}

void measure ()
{
  //byte sectionCounter = 0;
  int angle = 0;
  long duration;
  float distanceCm;

  angle = sectionCounter * 10;
  SensorServo.write(angle);
  delay(500);
  digitalWrite(9, LOW); //do the pulse
  delayMicroseconds(2);
  digitalWrite(9, HIGH);
  delayMicroseconds(10);
  digitalWrite(9, LOW);
  duration = pulseIn(10, HIGH, 10000);   //time for the pulse to echo
  distanceCm = duration / 29.1 / 2; //convert to cm (29.1 apparently a conversion factor)
  Serial.print("F");
  Serial.print(distanceCm);
  Serial.print("S");
  Serial.print(angle);
  Serial.println();
}
