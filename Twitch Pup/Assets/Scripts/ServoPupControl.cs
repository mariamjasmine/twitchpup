using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uniduino;

public class ServoPupControl : MonoBehaviour {

	public Arduino arduino;
	public int servo_pin = 9;
	private int servo_pos = 90;

	// Use this for initialization
	void Start () {
		arduino = Arduino.global;
		arduino.Log = (s) => Debug.Log("Arduino: " +s);

		arduino.Setup(ConfigurePins);


		ConfigurePins ();
	}

	void ConfigurePins ()
	{
		Debug.Log("set pin mode");
		arduino.pinMode(servo_pin, PinMode.SERVO);
	}

	void servoLeft(){

	}

	void servoRight(){

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
