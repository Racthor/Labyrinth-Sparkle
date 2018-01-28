using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void quitter() {
        Application.Quit();
    }

    public void retourMenu() {
        SceneManager.LoadScene( "lvl_1", LoadSceneMode.Single );
    }
}
