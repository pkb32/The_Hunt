using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject TheZombie;

     void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        TheZombie.SetActive(true);

    }
}
