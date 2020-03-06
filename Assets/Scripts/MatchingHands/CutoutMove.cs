using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutMove : MonoBehaviour
{
    public float speed;
    public Progress progress;
    private float z = 6f;
    private bool stop = false;

    // Update is called once per frame
    void Update()
    {
        z = z - (speed/100f);
        transform.position = new Vector3(0f, 1.5f, z);

        if (z < -4)
        {
            if (stop == false) {
                progress.pass();
                stop = true;
            }
            
        }
    }
}
