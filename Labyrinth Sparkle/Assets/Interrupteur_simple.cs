using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Interrupteur_simple : MonoBehaviour {
    public Canvas flux;
    public float portail;
    private bool on;

    void Start() {
        on = false;
    }

    void Update() {
        if ( flux.GetComponentInChildren<Image>().fillAmount >= portail ) {
            flux.GetComponent<Flux>().Unblocked = on;
        }
    }

    private void OnTriggerEnter( Collider other ) {
        on = !on;
    }
}
