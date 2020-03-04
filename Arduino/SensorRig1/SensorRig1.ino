#include <Servo.h>
#include <NewPing.h>

#define SONAR_NUM     3  // Number or sensors.
#define MAX_DISTANCE 200 // Max distance in cm.
#define PING_INTERVAL 33 // Milliseconds between pings.

unsigned long pingTimer[SONAR_NUM]; // When each pings.
unsigned int cm[SONAR_NUM]; // Store ping distances.
uint8_t currentSensor = 0; // Which sensor is active.
int TriggerPIN = 9;

NewPing sonar[SONAR_NUM] = { // Sensor object array.
  NewPing(TriggerPIN, 10, MAX_DISTANCE), //left
  NewPing(TriggerPIN, 11, MAX_DISTANCE), //front
  NewPing(TriggerPIN, 12, MAX_DISTANCE), //right
};

char delim[] = {
  'L',
  'F',
  'R',
  'S'
};

Servo SensorServo;

void setup() {
  Serial.begin(115200);

  SensorServo.attach(2);
  SensorServo.write(0);
  pingTimer[0] = millis() + 75; // First ping start in ms.
  for (uint8_t i = 1; i < SONAR_NUM; i++)
    pingTimer[i] = pingTimer[i - 1] + PING_INTERVAL;
}

void loop() {
  if (Serial.available()) {
    char start = Serial.read();
    if (start == 'I') {
      while(true) {
        clockwiseRotation();
        antiClockwiseRotation();
      }
    }
    // The rest of your code would go here.
  }
}

void clockwiseRotation() {
  for (int j = 0; j < 180; j++) {
    SensorServo.write(j);
    delay(20);
    collectSensorData(j);
  }
}

void antiClockwiseRotation() {
  for (int k = 180; k > 0; k--) {
    SensorServo.write(k);
    delay(20);
    collectSensorData(k);
  }
}

void collectSensorData(int servoAngle) {
  for (uint8_t i = 0; i < SONAR_NUM; i++) {
    if (millis() >= pingTimer[i]) {
      pingTimer[i] += PING_INTERVAL * SONAR_NUM;
      if (i == 0 && currentSensor == SONAR_NUM - 1)
        oneSensorCycle(servoAngle); // Do something with results.
      sonar[currentSensor].timer_stop();
      currentSensor = i;
      cm[currentSensor] = 0;
      sonar[currentSensor].ping_timer(echoCheck);
    }
  }
}

void echoCheck() { // If ping echo, set distance to array.
  if (sonar[currentSensor].check_timer())
    cm[currentSensor] = sonar[currentSensor].ping_result / US_ROUNDTRIP_CM;
}

void oneSensorCycle(int angle) { // Do something with the results.
  for (uint8_t i = 0; i < SONAR_NUM; i++) {
    Serial.print(delim[i]);
    Serial.print(cm[i]);
  }
  Serial.print('S');
  Serial.print(angle);
  Serial.println();
}
