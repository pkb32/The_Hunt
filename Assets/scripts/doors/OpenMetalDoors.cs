using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMetalDoors : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject leftDoor;
    public GameObject rightDoor;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 20)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                leftDoor.GetComponent<Animator>().Play("LeftDoor");
                rightDoor.GetComponent<Animator>().Play("RightDoor");
            }
        }

    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}