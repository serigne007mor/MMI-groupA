using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    bool firstleft, firstright, secondleft, secondright, thirdleft, thirdright, firstpass, secondpass, thirdpass;
    private int i;
    public GameObject first_cutout;
    public GameObject second_cutout;
    public GameObject third_cutout;
    private GameObject firstcutout;
    private GameObject secondcutout;
    private GameObject thirdcutout;
    private GameObject type;
    public LeftTest lefttest;
    public RightTest righttest;
    public CutoutMove cutoutmove;
    public Text leftpasstext;
    public Text rightpasstext;


    void Start()
    {
        firstleft = false;
        firstright = false;
        secondleft = false;
        secondright = false;
        thirdleft = false;
        thirdright = false;
        firstpass = false;
        secondpass = false;
        thirdpass = false;
        i = 1;
        leftpasstext.text = ("Left pass: ");
        rightpasstext.text = ("Right pass: ");

        firstcutout = (GameObject)Instantiate(first_cutout); 
    }

    public void increment(int number, string id)
    {
        if (i == 1 && number > 5 && id == "left")
        {
            Debug.Log("first left pass");
            leftpasstext.text = ("Left pass: True");
            firstleft = true;
        }
        else if (i == 1 && number > 5 && id == "right")
        {
            Debug.Log("first right pass");
            rightpasstext.text = ("Right pass: True");
            firstright = true;

        }
        else if (i == 2 && number > 5 && id == "left")
        {
            Debug.Log("second left pass");
            leftpasstext.text = ("Left pass: True");
            secondleft = true;
        }
        else if (i == 2 && number > 5 && id == "right")
        {
            Debug.Log("second right pass");
            rightpasstext.text = ("Right pass: True");
            secondright = true;

        }
        else if (i == 3 && number > 5 && id == "left")
        {
            Debug.Log("third left pass");
            leftpasstext.text = ("Left pass: True");
            thirdleft = true;
        }
        else if (i == 3 && number > 5 && id == "right")
        {
            Debug.Log("third right pass");
            rightpasstext.text = ("Right pass: True");
            thirdright = true;

        }
    }

    public void pass()
    {
        Debug.Log("Got into Pass");
        if (firstleft == true && firstright == true && firstpass == false) //if both hands have hit all the hitboxes for the firstcutout, destroy that ish
        {
            Destroy(firstcutout.gameObject);
            firstpass = true;
            lefttest.reset();
            righttest.reset();
            secondcutout = (GameObject)Instantiate(second_cutout);
            firstleft = false;
            firstright = false;
            cutoutmove.Stop();
            i = 2;
        }
        else if (secondleft == true && secondright == true && secondpass == false) //if both hands have hit all the hitboxes for the thirdcutout, destroy that ish
        {
            Destroy(secondcutout.gameObject);
            secondpass = true;
            lefttest.reset();
            righttest.reset();
            thirdcutout = (GameObject)Instantiate(third_cutout);
            secondleft = false;
            secondright = false;
            cutoutmove.Stop();
            i = 3;
        }
        else if (thirdleft == true && thirdright == true && thirdpass == false) //if both hands have hit all the hitboxes for the thirdcutout, destroy that ish
        {
            Destroy(thirdcutout.gameObject);
            thirdpass = true;
            lefttest.reset();
            righttest.reset();
            cutoutmove.Stop();
        }
        else
        {
            //Debug.Log("Move the cutout back to where it started");
            switch (i)
            {
                case 1:
                    Destroy(firstcutout.gameObject);
                    lefttest.reset();
                    righttest.reset();
                    firstcutout = (GameObject)Instantiate(first_cutout);
                    break;
                case 2:
                    Destroy(secondcutout.gameObject);
                    lefttest.reset();
                    righttest.reset();
                    secondcutout = (GameObject)Instantiate(second_cutout);
                    break;
                case 3:
                    Destroy(thirdcutout.gameObject);
                    lefttest.reset();
                    righttest.reset();
                    thirdcutout = (GameObject)Instantiate(third_cutout);
                    break;
                default:
                    break;
            }
        }
        
    }
}
