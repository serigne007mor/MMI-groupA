using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeftTest : MonoBehaviour
{
    public int lefthitboxes = 0;
    public Text leftcountText;
    public Progress progress;
    private string identifier = "left";

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("leftHand"))
        {
            lefthitboxes++;
            Debug.Log("Number of boxes hit: " + lefthitboxes);
            leftcountText.text = ("Left Count:" + lefthitboxes.ToString());
            progress.increment(lefthitboxes, identifier);
        }
    }

    public void reset()
    {
        lefthitboxes = 0;
        leftcountText.text = ("Left Count:" + lefthitboxes.ToString());
    }
}