using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class NewClimbing : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;

    private Vector3 lastRightPosition = new Vector3(0, 0, 0);
    private Vector3 lastLeftPosition = new Vector3(0, 0, 0);
    private bool climbing = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand)) {

            if (climbing)
            {
                Vector3 movement = rightHand.transform.position - lastRightPosition;
                transform.position -= movement;
            } else
            {
                climbing = true;
            }
            
        } else if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.LeftHand)) {

            if (climbing)
            {
                Vector3 movement = leftHand.transform.position - lastLeftPosition;
                transform.position -= movement;
            }
            else
            {
                climbing = true;
            }

        } else
        {
            climbing = false;
        }

        lastRightPosition = rightHand.transform.position;
        lastLeftPosition = leftHand.transform.position;

    }
}
