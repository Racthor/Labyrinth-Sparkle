using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class Interrupteur_levier : MonoBehaviour {

    public Canvas flux;
    public float portail;
    private int nbRobotsSurPoussoir = 0;

    void Start() {

    }

    void Update() {
        if ( flux.GetComponentInChildren<Image>().fillAmount >= portail ) {
            flux.GetComponent<Flux>().Unblocked = nbRobotsSurPoussoir == 2;
        }
    }

    private void OnTriggerEnter( Collider other ) { // fout la merde si il y a plus de 2 robots dessus.
        nbRobotsSurPoussoir = (nbRobotsSurPoussoir == 1)? 2 : 1;
        Debug.Log( "plop" + nbRobotsSurPoussoir );
    }

    private void OnTriggerExit( Collider other ) {
        nbRobotsSurPoussoir = (nbRobotsSurPoussoir == 2)? 1 : 0;
        Debug.Log( nbRobotsSurPoussoir );

    }
}
