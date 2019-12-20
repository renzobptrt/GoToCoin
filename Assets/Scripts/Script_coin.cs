/*
    Descripción: Script usado para configurar el GameObject Coin.
 */
//namespace: Compendio de librerias y cosas que se usarán en el código.
//Using: Indicar existencia de la carga de una libreria .
using System.Collections; //Colección de objetos.
using System.Collections.Generic; // Arrays.
using UnityEngine; // Motor de Unity


//Declaración de la clase.
public class Script_coin : MonoBehaviour {
    //Variable global y estática
    public static int coinsCount = 0;

	// Use this for initialization
	void Start () {
        Script_coin.coinsCount++;
        //Debug.Log("The game has started and now there are " + Script_coin.coinsCount + " coins");
	}
	
	// Update is called once per frame
	void Update () {
        /*Rotaremos la moneda en 30 grados y lo haremos consistente con la velocidad
          de la computadora al multiplicarlo por Time.deltaTime*/
        transform.Rotate(new Vector3(30f, 0f, 0f) * Time.deltaTime * 2);
	}
    /*Método que se llama automaticamente cuando otro collider entra en 
     contacto con la moneda.*/
    private void OnTriggerEnter(Collider other){
        //Debug.Log("Something has collided with the coin");
        if(other.CompareTag("Player")== true){//Comparará other con el Tag que lo chocará
            //Se descontará una moneda cada vez que lo recogamos.
            Script_coin.coinsCount--;
            Debug.Log("We have collected the coin and now there are " + Script_coin.coinsCount + " coins");
            Destroy(gameObject); /*Destruye el objeto de la escena, gameObject  
                                  funciona como "this".*/
            //Condicional para saber si el # de monedas llegó a 0.
            if(Script_coin.coinsCount == 0)
            {
                Debug.Log("The game has finished.");
                //Encontrará el gamemanagement de la lista de objetos de la escena.
                GameObject gameManager= GameObject.Find("GameManagement");
                //Destruirá el objeto ni bien juntemos todas las monedas.
                Destroy(gameManager);
                //Agrupará en un arreglo todos los FireWorks
                GameObject[] fireWorksSystem = GameObject.FindGameObjectsWithTag("Fireworks");
                //Bucle for usando un objeto dentro de otro para recorrer
                foreach(GameObject firework in fireWorksSystem){
                    //Recorrera cada objeto y lo reproducirá.
                    firework.GetComponent<ParticleSystem>().Play();
                }

            }
        }
    }
}
