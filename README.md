# Ultrasonic-Radar

An updated version of a previous project that would use a 3d printed mount for 3 ultrasonic sensors (hc-sr04) attached to a servo.

[Image soon to be uploaded]

The project in it's current state requires the Arduino be plugged directly into a usb port to communicate over serial however the plan will be to attach the module to a mobile platform that can be used to remotely map a room by sending the same data over wifi to the program. The program will then be able to display and analyse this data so that the user can make sense of it and get a 2d map of the area.

The repository includes code for the Arduino which shows how the lower level code works and then the C# WinForms application which acts as the high level code and interprets data. Some example data sets have also been included although imperfect they allow a user to see what can be achieved should data collection be successful that can be loaded when the program is run.
