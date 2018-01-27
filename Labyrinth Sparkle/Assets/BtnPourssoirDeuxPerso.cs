using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPourssoirDeuxPerso : MonoBehaviour {

    private int nbRobotsSurPoussoir = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public bool isDeuxRobots() {
        return (nbRobotsSurPoussoir >= 2) ? true : false;
    }

    private void OnTriggerEnter( Collider other ) {
        nbRobotsSurPoussoir += 1;
    }

    private void OnTriggerExit( Collider other ) {
        nbRobotsSurPoussoir -= 1;

    }
}
