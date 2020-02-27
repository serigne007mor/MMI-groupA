using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class leftCubeScript : MonoBehaviour {
  
 
    public SteamVR_Action_Boolean destroyAction;
    private Interactable interactable;


    void Start()
    {
        interactable = GetComponent<Interactable>();
    }


    //void Update()
    //{
    //    if (interactable.attachedToHand != null)
    //    {
    //        SteamVR_Input_Sources source = interactable.attachedToHand.handType;

    //        if (destroyAction[source].stateDown)
    //        {
    //            gameObject.SetActive(false);
    //        }
    //    }
    //}

    private void OnHandHoverBegin(Hand hand)
    {
        hand.ShowGrabHint();
    }


    private void OnHandHoverEnd(Hand hand)
    {
        hand.HideGrabHint();
    }


    private void OnHandHoverUpdate(Hand hand)
    {
        GrabTypes grabType = hand.GetGrabStarting();
        bool isGrabEnding = hand.IsGrabEnding(gameObject);

        if (interactable.attachedToHand == null && grabType != GrabTypes.None)
        {
            hand.AttachObject(gameObject, grabType);
            hand.HoverLock(interactable);
            hand.HideGrabHint();
        }

        else if (isGrabEnding)
        {
            hand.DetachObject(gameObject);
            hand.HoverLock(interactable);
        }
    }

    //void OnTriggerEnter (Collider other) {
    //    if (other.gameObject.CompareTag ("lefttHand")) {
    //        gameObject.SetActive (false);

    //    }

    //}
}