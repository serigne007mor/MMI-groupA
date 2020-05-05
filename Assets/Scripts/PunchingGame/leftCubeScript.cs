using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class leftCubeScript : MonoBehaviour
{
    public TextMesh score;
    public string destroyer;
    public AudioSource destroyed;
    private void Start()
    {
        destroyed = GetComponent<AudioSource>();
    }
    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag(destroyer))
        {
            destroyed.Play();
            gameObject.SetActive (false);
            score.text = (int.Parse(score.text) + 1).ToString();

        }

    }
}