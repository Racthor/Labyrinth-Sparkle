using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour {
    public bool doitChanger;
    public GameObject goQuiChangeSonMaterial;
    public Material primaire;
    public Material secondaire;

	void Update () {
        if (doitChanger) {
            goQuiChangeSonMaterial.GetComponent<MeshRenderer>().materials[1] = secondaire;
        } else {
            goQuiChangeSonMaterial.GetComponent<MeshRenderer>().materials[1] = primaire;
        }
	}
}
