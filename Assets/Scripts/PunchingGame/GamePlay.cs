using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    //public GameObject leftBabies;
    //public GameObject rightBabies;
    public int gamePlay;
    public GameObject restartPoint;
    public GameObject Hub;
    public GameObject wall;
    public TextMesh scoreText;
    public TextMesh timerText;
    private float startTime;
    public int endTime = 10;
    float finalTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (gamePlay == 0)
            quick();
        else
            timeMe();
    }

    void timeMe()
    {
        restartPoint.SetActive(false);
        float t = Time.time - startTime;
        //string minutes = ((int)t / 60).ToString();
        string seconds = ((t % 60)).ToString("f0");
        if (scoreText.text == "16")
        {
            finalTime = Time.time - startTime;
            wall.SetActive(false);
            restartPoint.SetActive(true);
            Hub.SetActive(true);
            scoreText.gameObject.SetActive(false);
            timerText.text = "Your final score is: " + scoreText.text + "/16";
            timerText.text = "It took you " + finalTime + " to finish";
        }
        else
            timerText.text = seconds;
    }

    void quick()
    {
        restartPoint.SetActive(false);
        float t = Time.time - startTime;
        //string minutes = ((int)t / 60).ToString();
        string seconds = (endTime - (t % 60)).ToString("f0");
        if (endTime - (t % 60) < 0)
        {
            timerText.text = "yepp";
            //leftBabies.SetActive(false);
            //rightBabies.SetActive(false);
            wall.SetActive(false);
            restartPoint.SetActive(true);
            Hub.SetActive(true);
            scoreText.gameObject.SetActive(false);
            timerText.text = "Your final score is: " + scoreText.text + "/16";
        }

        else
        {
            timerText.text = seconds;
        }
    }
}
