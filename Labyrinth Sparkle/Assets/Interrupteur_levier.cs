using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur_levier : MonoBehaviour {
    public GameObject porte;
    private int nbRobotsSurPoussoir = 0;

    void Start() {

    }

    void Update() {
        porte.GetComponent<Collider>().isTrigger = nbRobotsSurPoussoir == 2;
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
