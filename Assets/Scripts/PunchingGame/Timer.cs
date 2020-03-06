using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //public GameObject leftBabies;
    //public GameObject rightBabies;
    public TextMesh scoreText;
    public TextMesh timer;
    private float startTime;
    public int endTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        //string minutes = ((int)t / 60).ToString();
        string seconds = (endTime - (t % 60)).ToString("f0");
        if (endTime - (t % 60) < 0)
        {
            timer.text = "yepp";
            //leftBabies.SetActive(false);
            //rightBabies.SetActive(false);
        }

        else
        {
            timer.text = seconds;
        }
    }
}
