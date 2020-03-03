//This sketch is to test the radar and determine why sensor values always seem to form an arc
#include <Servo.h>
#include <NewPing.h>


Servo SensorServo;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  SensorServo.attach(2);
  SensorServo.write(0);
}

void loop() {
  // put your main code here, to run repeatedly:

}
