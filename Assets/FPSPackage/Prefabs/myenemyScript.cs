using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class myenemyScript : MonoBehaviour {

//	public GameObject[] lightbomb;
	// 型に対して変数　これを宣言という。
	NavMeshAgent agent;
	Transform target; 
	SpotlightScript lightOn;

	// Use this for initialization
	void Start () {
    // NavMeshAgentのComponentを取得する
		agent =  GetComponent<NavMeshAgent>();



		GameObject lightObject = GameObject.FindGameObjectWithTag("MainCamera");



		lightOn = lightObject.GetComponent<SpotlightScript> ();


	}
	
	// Update is called once per frame
	void Update () {
		if (lightOn.LightOn) { 
			agent.SetDestination (lightOn.transform.position);
		} else {
			agent.SetDestination (this.transform.position);
		}
		
//		lightbomb = GameObject.FindGameObjectsWithTag("lightbomb");
//		foreach (GameObject lightball in lightbomb) {
//			agent.SetDestination (lightball.transform.position);
//
//		}
	}
}
