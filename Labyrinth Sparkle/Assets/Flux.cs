using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flux : MonoBehaviour {
    public GameObject start;
    public GameObject middle;
    public GameObject ending;

    private Vector3 moveDirection;
    private float xX;
    private float yY;

    public GameObject courant { get; set; }
    public bool isCollision { get; set; }

    // Use this for initialization
    void Start () {
        xX = 1;
        yY = 0;
        isCollision = false;
        courant = start;
	}
	
	// Update is called once per frame
	void Update () {
        grandisation( courant );
	}

    private void grandisation(GameObject chemin ) {
        if ( !isCollision ) {
            moveDirection = new Vector3( xX, yY, 0 );
            chemin.transform.TransformDirection( moveDirection );
            moveDirection *= 1.6F;
        }
    }

    private void OnTriggerEnter( Collider other ) {
        Debug.Log( "ploptrigger" );
        isCollision = true;
        if ( other.gameObject.tag == "GameController" ) {
            if ( courant == start ) {
                xX = 0;
                yY = 1;
                courant = middle;
            }
            else {
                xX = -1;
                yY = 0;
                courant = ending;
            }
        }

    }
}
