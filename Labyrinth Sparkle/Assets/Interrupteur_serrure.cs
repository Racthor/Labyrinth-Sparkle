using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur_serrure : MonoBehaviour {
    public GameObject porte;
    private bool on = false;

    void Update() {
        porte.GetComponent<Collider>().isTrigger = on;
    }

    private void OnTriggerEnter( Collider other ) {
        on = !on;
    }
}
