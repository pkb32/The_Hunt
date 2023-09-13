using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyMusic : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name.Equals("SampleScene"))
        {
            Destroy(gameObject);
        }
    }
}
