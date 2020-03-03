using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class leftCubeScript : MonoBehaviour {


    public string destroyer;
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag(destroyer)) {
            gameObject.SetActive (false);

        }

    }
}