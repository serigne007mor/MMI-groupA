using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    public GameObject[] hims;
    public bool hasHim;
    // Start is called before the first frame update
    void Start()
    {
        if(!hasHim)
        {
            Invoke("Spawn", Random.Range(3f, 7f));
        }
    }
    void Spawn()
    {
        if(!hasHim)
        {
            int num = Random.Range(0, hims.Length);
            GameObject him = Instantiate(hims[num], transform.position, Quaternion.identity) as GameObject;
            //him.GetComponent<himBehavior>.myParent = this.gameObject;
        }
        
        Invoke("Spawn", Random.Range(3f, 7f));
    }


    // Update is called once per frame
    void Update()
    {

    }
}