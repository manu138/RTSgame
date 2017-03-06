using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
  
	// Use this for initialization
	void Start ()
    {
      Soldier  soldado = new Soldier(100,100,10,"a");
        soldado.attack = 100;
        soldado.health = 100;
        soldado.defense = 10;
        soldado.team = "A";

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("ahi esta");
    }
}
