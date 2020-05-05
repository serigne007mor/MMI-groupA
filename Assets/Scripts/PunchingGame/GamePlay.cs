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
    int currentTime;
    float finalTime;
    public int countdownTime;
    public TextMesh countdownDisplay;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
        currentTime = 0;
        scoreText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
    }

    IEnumerator timeMe()
    {
        scoreText.gameObject.SetActive(true);
        timerText.gameObject.SetActive(true);
        scoreText.text = "0";
        restartPoint.SetActive(false);
        string seconds = "";
        while (scoreText.text != "16" && seconds != endTime.ToString())
        {
            seconds = (currentTime++).ToString();
            timerText.text = seconds.ToString();
            yield return new WaitForSeconds(1f);
        }


        finalTime = Time.time - startTime;
        wall.SetActive(false);
        restartPoint.SetActive(true);
        Hub.SetActive(true);
        scoreText.gameObject.SetActive(false);
        if (seconds != endTime.ToString())
        {
            timerText.text = "Congrats, You Finished in: " + currentTime + " teleporte here to Try again? \n or look behing you and go back to the hub";
        }
        else
            timerText.text = "You took way too long! teleporte here Try again? \n or look behing you and go back to the hub";



        yield return new WaitForSeconds(1f);
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            if (countdownTime == 3)
            {
                countdownDisplay.text = "Hello!";
                yield return new WaitForSeconds(1f);

                countdownDisplay.text = "Welcome to the punching game";
                yield return new WaitForSeconds(2f);

                countdownDisplay.text = "In this game your goal is to destroy all the babies ASAP";
                yield return new WaitForSeconds(3f);

                countdownDisplay.text = "But you can only destroy the red babies with your left hand";
                yield return new WaitForSeconds(3f);

                countdownDisplay.text = "And the blue babies with your right hand";
                yield return new WaitForSeconds(2f);

                countdownDisplay.text = "try to complete it in:" + endTime + " seconds";
                yield return new WaitForSeconds(2f);

                countdownDisplay.text = "The game will start in";
                yield return new WaitForSeconds(2f);
            }
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";
        

        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        StartCoroutine(timeMe());
    }

}
