using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_decision : MonoBehaviour {

	public bool willItRainToday = false;

	// Use this for initialization
	void Start () {
		
		/* if(willItRainToday){
			Debug.Log("No te olvides de coger el paraguas");
		}else{
			Debug.Log("No lo cojas, hace mucho sol");
		}*/

		if(!willItRainToday){
			Debug.Log("Vamos al cine");
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
