using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors2 : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Door;


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
            if (Input.GetButtonDown("Action2"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                Door.GetComponent<Animator>().Play("Door3Opening");

            }
        }

    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
