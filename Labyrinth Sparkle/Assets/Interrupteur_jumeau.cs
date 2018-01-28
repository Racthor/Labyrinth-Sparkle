using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur_jumeau : MonoBehaviour {
    public GameObject interrupteur;
    public GameObject porte;

    private bool porteDebloquer;
    public bool PorteDebloquer { get { return porteDebloquer; } }

    // Use this for initialization
    void Start() {
        porteDebloquer = false;

    }

    // Update is called once per frame
    void Update() {

        porte.GetComponent<Collider>().isTrigger = (PorteDebloquer && interrupteur.GetComponent<Interrupteur_jumeau>().PorteDebloquer) ? true : false;

    }
    
    private void OnTriggerEnter( Collider other ) {
        porteDebloquer = true;
    }
    private void OnTriggerExit( Collider other ) {
        porteDebloquer = false;

    }
}
