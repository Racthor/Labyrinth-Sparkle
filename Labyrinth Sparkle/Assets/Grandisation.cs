using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandisation : MonoBehaviour {
    private GameObject Flux;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter( Collider other ) {
        Debug.Log( "ploptrigger" );
        other.gameObject.GetComponent<Flux>();
        other.gameObject.GetComponent<Flux>().isCollision = true;
        if ( other.gameObject.tag == "GameController" ) {
            if ( other.gameObject.GetComponent<Flux>().courant == other.gameObject.GetComponent<Flux>().start ) {
                other.gameObject.GetComponent<Flux>().courant = other.gameObject.GetComponent<Flux>().middle;
            }
            else {
                other.gameObject.GetComponent<Flux>().courant = other.gameObject.GetComponent<Flux>().ending;
            }
        }

    }

    private void OnCollisionEnter( Collision collision ) {
        Debug.Log( "plop" );
        collision.gameObject.GetComponent<Flux>();
        collision.gameObject.GetComponent<Flux>().isCollision = true;
        if ( collision.gameObject.tag == "GameController" ) {
            if ( collision.gameObject.GetComponent<Flux>().courant == collision.gameObject.GetComponent<Flux>().start ) {
                collision.gameObject.GetComponent<Flux>().courant = collision.gameObject.GetComponent<Flux>().middle;
            }
            else {
                collision.gameObject.GetComponent<Flux>().courant = collision.gameObject.GetComponent<Flux>().ending;
            }
        }
    }

    private void OnCollisionExit( Collision collision ) {
        collision.gameObject.GetComponent<Flux>().isCollision = true;
    }
}
