using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightScript : MonoBehaviour {
	public GameObject Light;
	public bool LightOn;
	// Use this for initialization
	void Start () {
		LightOn = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.X)) {
			if (LightOn == false) {
				LightOn = true;
				Light.SetActive (true);

			} else {
				LightOn = false;
				Light.SetActive (false);


			}
		}

		}
	}


