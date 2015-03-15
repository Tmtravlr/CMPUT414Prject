using UnityEngine;
using System.Collections;

public class isUnderWater : MonoBehaviour {

	public GameObject player;
	public bool playerUnderwater;
	public double water_height = -5.3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		checkHeight ();

			Debug.Log(player.transform.position);
		}

	bool checkHeight(){
		if (player.transform.position.y <= water_height) {
						return playerUnderwater = true;
				} else {
			return playerUnderwater = false;
				}
		}
}
