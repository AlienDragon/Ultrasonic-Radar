#include <Servo.h>

static Servo sensorServo;

#define SERVO_UPPER_LIMIT  (180) // Degrees
#define SERVO_STEP         (10)  // Degrees

// Speed of sound in dry air: 343m/s
//  1 / 0.0343 = 29.1
#define SPEED_OF_SOUND_INV (29.1)

#define TRIGGER_PIN (9)
#define ECHO_PIN    (10)
#define SERVO_PIN   (2)

void setup()
{
  Serial.begin(115200);

  sensorServo.attach(SERVO_PIN);
  sensorServo.write(0);

  pinMode(TRIGGER_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);
}

void loop()
{
  for (int angle = 0; angle < SERVO_UPPER_LIMIT; angle += SERVO_STEP)
    measure(angle);

  for (int angle = SERVO_UPPER_LIMIT; angle > 0; angle -= SERVO_STEP)
	  measure(angle);
}


void measure (int angle)
{
  sensorServo.write(angle);

  delay(500);

  // ensure trigger pin is low
  digitalWrite(TRIGGER_PIN, LOW); //do the pulse
  delayMicroseconds(2);

  // do the actual pulse
  digitalWrite(TRIGGER_PIN, HIGH);
  delayMicroseconds(10);

  // reset it again to low.
  digitalWrite(TRIGGER_PIN, LOW);

  // time for the pulse to echo
  const long duration = pulseIn(ECHO_PIN, HIGH, 10000);

  // convert to cm
  const float distanceCm = (duration / SPEED_OF_SOUND_INV) / 2;

  Serial.print("F");
  Serial.print(distanceCm);
  Serial.print("S");
  Serial.print(angle);
  Serial.println();
}
