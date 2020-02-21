using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutMove : MonoBehaviour
{
    public float speed;
    private float z = 6f;

    // Update is called once per frame
    void Update()
    {
        z = z - (speed/100f);
        transform.position = new Vector3(0f, 1.5f, z);
    }
}
