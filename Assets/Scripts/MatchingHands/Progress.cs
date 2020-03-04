using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    bool firstleft, firstright, secondleft, secondright, thirdleft, thirdright;
    public GameObject first_cutout;
    public GameObject second_cutout;
    public GameObject third_cutout;
    private GameObject firstcutout;
    private GameObject secondcutout;
    private GameObject thirdcutout;

    void Start()
    {
        firstleft = false;
        firstright = false;
        secondleft = false;
        secondright = false;
        thirdleft = false;
        thirdright = false;
    }

    public void increment(int number, string id)
    {
        if (firstleft == false && number > 5 && id == "left")
        {
            Debug.Log("first left pass");
            firstleft = true;
        }
        else if (firstright == false && number > 5 && id == "right")
        {
            Debug.Log("first left pass");
            firstright = true;

        }
    }

    public void pass()
    {
        Debug.Log("Got into Pass");
    }

    void SpawnNew()
    {
        firstcutout = (GameObject)Instantiate(first_cutout);
        secondcutout = (GameObject)Instantiate(second_cutout);
        thirdcutout = (GameObject)Instantiate(third_cutout);
    }
}
