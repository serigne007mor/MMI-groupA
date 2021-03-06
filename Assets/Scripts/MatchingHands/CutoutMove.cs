﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutMove : MonoBehaviour
{
    public float speed;
    public Progress progress;
    private float z = 6f;
    private bool stop = false;
    private bool stopcalling = true;
    public GameObject type;

    void Start()
    {
        progress = GameObject.FindObjectOfType<Progress>();
        stopcalling = true;
    }
    // Update is called once per frame
    void Update()
    {
        z = z - (speed/100f);
        transform.position = new Vector3(0f, 0f, z);

        if ((z < -4) && (stopcalling = true))
        {
            thing();
            stopcalling = false;
        }
    }
     
    void thing()
    {
        if (stop == false)
        {
            progress.pass();
            stop = true;
        }
    }
    public void Stop()
    {
        stopcalling = false;
    }
}
