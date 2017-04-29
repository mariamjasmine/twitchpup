using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uniduino;

public class ServoPup : MonoBehaviour {

	public Arduino arduino;

	public int pin = 9;

	// Use this for initialization
	void Start () {
		arduino = Arduino.global;
		arduino.Setup (ConfigurePins);

		StartCoroutine (pupLoop ());
	}

	void ConfigurePins(){
		arduino.pinMode (pin, PinMode.SERVO);
	}
	
	IEnumerator pupLoop()
	{
		while(true)
		{                  
			arduino.analogWrite(pin, 0);
			yield return new WaitForSeconds(1);

			arduino.analogWrite(pin, 180);
			yield return new WaitForSeconds(1);                
		}

	}


}
