using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeftTest : MonoBehaviour
{
    public int lefthitboxes = 0;
    public Text leftcountText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand"))
        {
            lefthitboxes++;
            Debug.Log("Number of boxes hit: " + lefthitboxes);
            leftcountText.text = ("Left Count:" + lefthitboxes.ToString());
        }
    }
}