using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    bool firstleft, firstright, secondleft, secondright, thirdleft, thirdright;
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

    void Start()
    {
        firstleft = false;
        firstright = false;
        secondleft = false;
        secondright = false;
        thirdleft = false;
        thirdright = false;
        i = 1;

        firstcutout = (GameObject)Instantiate(first_cutout); 
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
            Debug.Log("first right pass");
            firstright = true;

        }
        else if (secondleft == false && number > 5 && id == "left")
        {
            Debug.Log("second left pass");
            secondleft = true;
        }
        else if (secondright == false && number > 5 && id == "right")
        {
            Debug.Log("second right pass");
            secondright = true;

        }
        else if (thirdleft == false && number > 5 && id == "left")
        {
            Debug.Log("third left pass");
            thirdleft = true;
        }
        else if (thirdright == false && number > 5 && id == "right")
        {
            Debug.Log("third right pass");
            thirdright = true;

        }
    }

    public void pass()
    {
        Debug.Log("Got into Pass");
        if (firstleft == true && firstright == true) //if both hands have hit all the hitboxes for the firstcutout, destroy that ish
        {
            Destroy(firstcutout.gameObject);
            lefttest.reset();
            righttest.reset();
            secondcutout = (GameObject)Instantiate(second_cutout);
            firstleft = false;
            firstright = false;
            cutoutmove.Stop();
            i = 2;
        }
        else if (secondleft == true && secondright == true) //if both hands have hit all the hitboxes for the thirdcutout, destroy that ish
        {
            Destroy(secondcutout.gameObject);
            lefttest.reset();
            righttest.reset();
            thirdcutout = (GameObject)Instantiate(third_cutout);
            firstleft = false;
            firstright = false;
            cutoutmove.Stop();
            i = 3;
        }
        else if (thirdleft == true && thirdright == true) //if both hands have hit all the hitboxes for the thirdcutout, destroy that ish
        {
            Destroy(thirdcutout.gameObject);
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
