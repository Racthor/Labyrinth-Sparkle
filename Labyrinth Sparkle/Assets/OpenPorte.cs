using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPorte : MonoBehaviour {
    public GameObject porte;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        porte.GetComponent<Collider>().isTrigger = (GetComponentInChildren<Levier>().isOpen()) ? true : false;

	}
}
