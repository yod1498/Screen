using UnityEngine;
using System.Collections;

public class CameraAdjustScript : MonoBehaviour {

	public float h320 = 0.00625F;
	public float h640 = 0.003125F;

	
	// Use this for initialization
	void Start () {
		GetComponent<Camera>().orthographicSize = 1; 
	}

	// Update is called once per frame
	void Update () {

		// H = 320
		if(Input.GetKey(KeyCode.E)) {
			GetComponent<Camera>().transform.localScale = new Vector3(h320,h320,h320);
		}

		// H = 640
		if(Input.GetKey(KeyCode.Q)) {
			GetComponent<Camera>().transform.localScale = new Vector3(h640,h640,h640);
		}
	}
}

