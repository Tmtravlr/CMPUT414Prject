using UnityEngine;
using System.Collections;

public class UnderwaterControl : MonoBehaviour {

	//If true, the listener is concidered underwater
	public bool underwater;

	//The player and global water height (for this example)
	public GameObject player;
	public double waterHeight = -5.3;

	//The filter (this script creates it) and cutoff frequency
	private AudioLowPassFilter lowpassFilter;
	public float cutoffFrequency = 800.0f;

	void Start () {
		//Create a low pass filter to use
		lowpassFilter = gameObject.AddComponent<AudioLowPassFilter>() as AudioLowPassFilter;
	}

	void Update () {

		//Update the underwater variable here however you need to update it.
		//For our example, it's a really simple height check.

		/**************************/ 

		underwater = player.transform.position.y <= waterHeight;
		
		/**************************/
		
		//When underwater, humans can't hear higher frequencies as well. Therefore, lower the low
		//pass cutoff frequency. Otherwise set it to 20,000 Hz, the maximum that humans can hear.

		if (underwater) {
			lowpassFilter.cutoffFrequency = cutoffFrequency;
		} else {
			lowpassFilter.cutoffFrequency =  20000.0f;
		}
	}
}
