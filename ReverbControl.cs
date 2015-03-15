using UnityEngine;
using System.Collections;

public class ReverbControl : MonoBehaviour {

	public AudioSource audioSource;
	public AudioReverbFilter reverbFilter;

	// Use this for initialization
	void Start () {
		reverbFilter = gameObject.AddComponent<AudioReverbFilter>() as AudioReverbFilter;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
