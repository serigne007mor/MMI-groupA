using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCubeScript : MonoBehaviour
{
    public string destroyer;

    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag(destroyer))
            {
                gameObject.SetActive(false);
                
            }


        }
}
