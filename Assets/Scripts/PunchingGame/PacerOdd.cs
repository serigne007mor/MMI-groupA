using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacerOdd : MonoBehaviour
{
    public float min = 0f;
    public float max = 0f;
    
    // Use this for initialization
    void Start()
    {
        //startTime = Time.time;
        min = transform.position.x - 1;
        max = transform.position.x;
     

    }
    void Update()
    {
        
        if((Time.time) % 2 < 0.9)
            transform.position = new Vector3(Mathf.PingPong((Time.time) * 2, max - min) + min, transform.position.y, transform.position.z);

    }

    
}
