using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class leftCubeScript : MonoBehaviour {



    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag ("lefttHand")) {
            gameObject.SetActive (false);

        }

    }
}