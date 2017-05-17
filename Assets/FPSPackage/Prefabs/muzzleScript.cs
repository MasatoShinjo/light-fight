using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muzzleScript : MonoBehaviour {


	public GameObject ballet; //bulletのPrefab

	public float speed = 5;
	public int shot = 5;

	public Text lbText;

	// Update is called once per frame

	void Start(){

		lbText.text = "lightbomb: " + shot.ToString ();
	}
	void Update ()
	{
		
		if (Input.GetKeyDown(KeyCode.Z)) {

			shot --;

			if (shot >= 0) {
				Shot ();
				lbText.text = "lightbomb: " + shot.ToString ();
			} 
		}

	}

	void Shot(){

		//shot --;
		GameObject obj = Instantiate(ballet,transform.position,transform.rotation) as GameObject;
		obj.GetComponent<Rigidbody>().velocity = transform.forward * speed;
		//飛ばす向きは muzzleオブジェクトのz軸方向の向き→transform.forward
	}
}































