using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

    public GameObject manager;
    private Distancia distancia_script;

	// Use this for initialization
	void Start () {
        distancia_script = manager.GetComponent<Distancia>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collisionador)
    {
        if(collisionador.gameObject.tag == "Player")
        {
            distancia_script.GuardarDistancia("Distancia_Actual", (int)distancia_script.distancia + 1);
            distancia_script.DistanciaMayor((int)distancia_script.distancia + 1);

            Debug.Log("Distancia Actual: " + distancia_script.RecuperarDistancia("Distancia_Actual"));
            Debug.Log("Distancia Mayor: " + distancia_script.RecuperarDistancia("Distancia_Mayor"));

            Application.LoadLevel(2);
        }
    }
}
