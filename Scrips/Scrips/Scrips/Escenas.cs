using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenas : MonoBehaviour {


    public void Jugar()
    {
        Application.LoadLevel(1);
    }

    public void Salir()
    {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
