using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Interrupteur_jumeau : MonoBehaviour {
    public GameObject interrupteur;
    public Canvas flux;
    public float portail;

    private bool porteDebloquer;
    public bool PorteDebloquer { get { return porteDebloquer; } }

    // Use this for initialization
    void Start() {
        porteDebloquer = false;

    }

    // Update is called once per frame
    void Update() {
        if ( flux.GetComponentInChildren<Image>().fillAmount >= portail ) {
            flux.GetComponent<Flux>().Unblocked = porteDebloquer && interrupteur.GetComponent<Interrupteur_jumeau>().PorteDebloquer;
        }
    }
    
    private void OnTriggerEnter( Collider other ) {
        porteDebloquer = true;
    }
    private void OnTriggerExit( Collider other ) {
        porteDebloquer = false;

    }
}
