using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalHealth : MonoBehaviour
{

    public static int currentHealth = 100;
    public float internalHealth;
    public Image HealthBar;


    void Update()
    {
        internalHealth = currentHealth;
        if(currentHealth<=0)
        {
            SceneManager.LoadScene(1);
        }
        HealthBar.fillAmount = internalHealth/100;
    }
    
}