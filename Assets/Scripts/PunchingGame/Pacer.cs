using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pacer : MonoBehaviour
{
    private const double V = 0.9;
    public float min = 0f;
    public float max = 0f;
    float speed = 0f;
    GameObject[] cubes;
    
    // Use this for initialization
    //void Start()
    //{
    //    cubes = GameObject.FindGameObjectsWithTag("leftCube");
    //    min = transform.position.x - 1;
    //    max = transform.position.x;

    //}
    //    IEnumerator Waitfor(float duration)
    //{
    //    //This is a coroutine
    //   Debug.Log("Start Wait() function. The time is: "+Time.time);
    //    Debug.Log( "Float duration = "+duration);
    //     yield return new WaitForSeconds(duration);   //Wait
    //    Debug.Log("End Wait() function and the time is: "+Time.time);
    //}

    //private void BackAndForth(GameObject cube)
    //{
    //    cube.transform.position = new Vector3(Mathf.PingPong((Time.time * speed),1)+min, cube.transform.position.y, cube.transform.position.z);
        
    //}
    //// Update is called once per frame
    //void Update()
    //{

    //    transform.position = new Vector3(Mathf.PingPong((Time.time * speed), max - min) + min, transform.position.y, transform.position.z);
    //    //transform.position = new Vector3(Mathf.PingPong((Time.time * speed), 1) + min, transform.position.y, transform.position.z);
    //    //System.Random r = new System.Random();
    //    //int rInt = r.Next(0, cubes.Length);
    //    //BackAndForth(cubes[rInt]);

    //}



    // Use this for initialization

    void Start()
    {
        //startTime = Time.time;
        min = transform.position.x - 1;
        max = transform.position.x+0.1f;


    }
    void Update()
    {

        if (Time.time % 2 > V)
        {
            transform.position = new Vector3(Mathf.PingPong((Time.time) * 2, max - min) + min, transform.position.y, transform.position.z);
        }
    }


}
