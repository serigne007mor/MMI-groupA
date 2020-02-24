using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int hitboxes = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hands"))
        {
            hitboxes++;
            Debug.Log("Number of boxes hit: " + hitboxes);
        }
    }
}
