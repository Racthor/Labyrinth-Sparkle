using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.


public class Flux : MonoBehaviour {
    public Image flux;
    public float waitTime = 30.0f;
    public bool Unblocked { get; set; }
    // Use this for initialization
    void Start () {
        Unblocked = true;
	}
    // Update is called once per frame
    void Update() {
        if ( Unblocked ) {
            flux.fillAmount += 1.0f / waitTime * Time.deltaTime;
        }
    }


}
