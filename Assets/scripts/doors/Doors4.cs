using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors4 : MonoBehaviour
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
            if (Input.GetButtonDown("Action3"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                Door.GetComponent<Animator>().Play("Door4");

            }
        }

    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
