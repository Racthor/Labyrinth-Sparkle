using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levier : MonoBehaviour {

    private bool on = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public bool isOpen () {
        return on;
    }

    private void OnTriggerEnter( Collider other ) {
        on = !on;
    }
}
