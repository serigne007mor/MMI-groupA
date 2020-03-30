using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCubeScript : MonoBehaviour
{
    public string destroyer;
    public TextMesh score;
    void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag(destroyer))
            {
                gameObject.SetActive(false);
                score.text = (int.Parse(score.text) + 1).ToString();

        }


        }
}
