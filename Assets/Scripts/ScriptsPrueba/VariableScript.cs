using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour {

	/* Seccion de variables*/
	//Estilo camelcase lo entiende el unity, detecta mayusculas y los separa
	public int number1 = 5;
	public int number2 = 8;

	void Awake(){
		Debug.Log("El objeto a despertado");
	}

	// Use this for initialization
	void Start () {
		Debug.Log("El objeto a arrancado");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("El objeto se esta actualizando");
		//Time.time es el tiempo transcurrido desde el arranque
		Debug.Log(Time.time);
		if(Input.GetKeyDown(KeyCode.Return)){
			AddTwoNumbers();
		}
	}

	void AddTwoNumbers(){
		Debug.Log(number1 + number2);
	}
}
