String data;
char firstChar;

void setup() {
  // Connect to the same port as in C#
  Serial.begin(9600);

  pinMode(8, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    data = Serial.readString();

    firstChar = data.charAt(0);

    if(firstChar == 'O'){
      digitalWrite(8, HIGH);
    }

    if(firstChar == 'F'){
      digitalWrite(8, LOW);
    }
  }
}
