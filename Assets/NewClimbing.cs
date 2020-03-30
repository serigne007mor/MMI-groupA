using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class NewClimbing : MonoBehaviour
{
    public GameObject leftHand;
    public GameObject rightHand;

    public GameObject player;

    private Vector3 lastRightPosition;
    private Vector3 lastLeftPosition;
    private bool climbing;

    // Start is called before the first frame update
    void Start()
    {
        lastRightPosition = new Vector3(0, 0, 0);
        lastLeftPosition = new Vector3(0, 0, 0);
        climbing = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(lastRightPosition);
        if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.RightHand))
        {
            Debug.Log("pressing right down and climbing: " + climbing);
            if (climbing)
            {
                Debug.Log("climbing");
                Debug.Log(rightHand.transform.position);
                Debug.Log(lastRightPosition);
                Vector3 movement = rightHand.transform.position - lastRightPosition;
                Debug.Log(movement);
                player.transform.position -= movement;
            } else
            {
                Debug.Log("setting climbing to true");
                climbing = true;
            }
            
        } else if (SteamVR_Actions._default.GrabPinch.GetStateDown(SteamVR_Input_Sources.LeftHand)) {

            if (climbing)
            {
                Debug.Log("moving left hand");
                Vector3 movement = leftHand.transform.position - lastLeftPosition;
                player.transform.position -= movement;
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
