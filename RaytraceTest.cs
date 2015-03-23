using UnityEngine;
using System.Collections;

public class RaytraceTest : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit[] hits;
		Vector3 diffVec = transform.position - player.transform.position;
		float diffLength = diffVec.magnitude;
		hits = Physics.RaycastAll(player.transform.position, diffVec, diffLength);
		Debug.Log (hits.Length);
		/*
		while (i < hits.Length) {
			RaycastHit hit = hits[i];
			Renderer rend = hit.transform.GetComponent<Renderer>();
			if (rend) {
				rend.material.shader = Shader.Find("Transparent/Diffuse");
				rend.material.color.a = 0.3F;
			}
			i++;
		}*/
	}
}
