using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerScene : MonoBehaviour
{
    public bool attackTrigger = false;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (attackTrigger == true)
        {
             SceneManager.LoadScene(4);
        }


    }
    void OnTriggerEnter()
    {
        attackTrigger = true;
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
    }

   
}
