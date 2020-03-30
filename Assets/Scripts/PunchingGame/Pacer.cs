using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float min = 0f;
    public float max = 0f;
    // Use this for initialization
    void Start()
    {

        min = transform.position.x - 1;
        max = transform.position.x;

    }
        IEnumerator Wait(float duration)
    {
        //This is a coroutine
       Debug.Log("Start Wait() function. The time is: "+Time.time);
        Debug.Log( "Float duration = "+duration);
         yield return new WaitForSeconds(duration);   //Wait
        Debug.Log("End Wait() function and the time is: "+Time.time);
    }
    // Update is called once per frame
    void Update()
    {
        if ((Time.time) % 2 > 0.9)
            transform.position = new Vector3(Mathf.PingPong((Time.time) * 2, max - min) + min, transform.position.y, transform.position.z);

    }


}
