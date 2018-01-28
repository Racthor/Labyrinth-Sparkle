using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.
using UnityEngine.SceneManagement;

public class Flux : MonoBehaviour {
    public Image flux;
    public float waitTime = 30.0f;
    public bool Unblocked { get; set; }
    private float timer;
    // Use this for initialization
    void Start () {
        Unblocked = true;
        timer = 0;
	}
    // Update is called once per frame
    void Update() {
        if ( Unblocked ) {
            timer = 0;
            flux.fillAmount += 1.0f / waitTime * Time.deltaTime;
        } else {
            timer += 1.0f * Time.deltaTime;
        }

        if(timer >= waitTime ) {
            Debug.Log( "BOOM" );
            SceneManager.LoadScene( 0, LoadSceneMode.Single );
        }
        
    }


}
