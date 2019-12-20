
/*
    Descripción: Este script permitira asignar el valor del tiempo.
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para usar el Scene Manager

public class Script_timer : MonoBehaviour {
    //publico permitira cambiar en el inspector el valor
    public float maxTime = 180f;
    //privado no permitirá que otro script haga uso de esta variable.
    private float countDown = 0f;

	// Use this for initialization
	void Start () {
        countDown = maxTime;
	}
	
    //Usado para saltos de tiempo entre frame de manera uniforme
    private void FixedUpdate(){
        //Debug.Log(Time.time);
    }   

	// Update is called once per frame
	void Update () {
        /*El deltaTime es el tiempo en segundos que ha pasado desde que se 
         renderizó en pantalla el último frame anterior.*/
        //countDown = countDown - Time.deltaTime;
        countDown -= Time.deltaTime;

        //Debug.Log("Countdown: " + countDown);

        if(countDown <= 0){
            Debug.Log("Te has quedado sin tiempo... has perdido.");
            //Volvemos a 0 el contador de monedas
            Script_coin.coinsCount = 0;
            //Recargaremmos la escena al principio.
            SceneManager.LoadScene("MainScene");
        }
	}
}
