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

        if ( timer >= waitTime ) {
            Debug.Log( "BOOM" );
            SceneManager.LoadScene( 0, LoadSceneMode.Single );
        }
        
        if ( flux.fillAmount == 1 ) {
            chgtFlux( flux.GetComponent<ChainageFlux>().fluxSuivant );
            if ( flux.fillAmount == 1 ) {
                Victoire(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void chgtFlux(Image newFlux) {
        flux = newFlux;
        timer = 0;
    }

    private void Victoire( string sceneName ) {
        switch ( sceneName ) {
            case "lvl_1":
                SceneManager.LoadScene( "lvl_2", LoadSceneMode.Single );
                break;
            case "lvl_2":
                SceneManager.LoadScene( "lvl_3", LoadSceneMode.Single );
                break;
            case "lvl_3":
                SceneManager.LoadScene( "lvl_4", LoadSceneMode.Single );
                break;
            case "lvl_4":
                SceneManager.LoadScene( "lvl_5", LoadSceneMode.Single );
                break;
            case "lvl_5":
                SceneManager.LoadScene( "lvl_6", LoadSceneMode.Single );
                break;
            case "lvl_6":
                SceneManager.LoadScene( "lvl_7", LoadSceneMode.Single );
                break;
            case "lvl_7":
                SceneManager.LoadScene( "GameVictory", LoadSceneMode.Single );
                break;
        }
    }

}
