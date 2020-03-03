using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RightTest : MonoBehaviour
{
    public int righthitboxes = 0;
    public Text rightcountText;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("rightHand"))
        {
            righthitboxes++;
            Debug.Log("Number of boxes hit: " + righthitboxes);
            rightcountText.text = ("Right Count:" + righthitboxes.ToString());
        }
    }
}