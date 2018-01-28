using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Interrupteur_simple : MonoBehaviour {
    public Image flux;
    public float portail;
    private bool on = false;

    void Start() {

    }

    void Update() {
        //flux.fillAmount == portail;
        //porte.GetComponent<Collider>().isTrigger = on;

    }

    private void OnTriggerEnter( Collider other ) {
        on = !on;
    }
}
