using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBirth : MonoBehaviour
{
    public GameObject Spawner;
    public bool stopSpawing = false;
    public float spawnTime;
    public float spawnDelay;
    public int time;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(Spawner, transform.position, transform.rotation);
        if(stopSpawing)
        {
            CancelInvoke("SpawnObject");
        }
    }
  
}
