using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeepMusic : MonoBehaviour
{
    // Start is called before the first frame update
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
