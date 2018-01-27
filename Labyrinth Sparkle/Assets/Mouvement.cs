using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour {
    public float speed = 16.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;
    private bool    interrupteur = false;

    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if ( controller.isGrounded ) {
            moveDirection = new Vector3( Input.GetAxis( "Horizontal" ), 0, Input.GetAxis( "Vertical" ) );
            moveDirection = transform.TransformDirection( moveDirection );
            moveDirection *= speed;

        }
        if ( Input.GetButton( "R1" ) ) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 1 ).GetComponent<CharacterController>().enabled = true;
        }
        if ( Input.GetButton( "R2" )) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 2 ).GetComponent<CharacterController>().enabled = true;
        }
        if ( Input.GetButton( "R3" ) ) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 3 ).GetComponent<CharacterController>().enabled = true;
        }
        if ( Input.GetButton( "R4" ) ) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 4 ).GetComponent<CharacterController>().enabled = true;
        }
        if ( Input.GetButton( "R5" ) ) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 5 ).GetComponent<CharacterController>().enabled = true;
        }
        if ( Input.GetButton( "R6" ) ) {
            this.GetComponent<CharacterController>().enabled = false;
            GameObject.Find( "Robot_" + 6 ).GetComponent<CharacterController>().enabled = true;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move( moveDirection * Time.deltaTime );
    }
}