using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public List<GameObject> locationsToSpawn=new List<GameObject>();
    public float timeToSpawn;
    private float currentTimeToSpawn;
    
    public bool isRandomized;
    // Start is called before the first frame update
    void Start()
    {
       currentTimeToSpawn = timeToSpawn;
    }
    void Update()
    {
        UpdateTimer();
    }

    // Update is called once per frame
    void UpdateTimer()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else 
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }
    public void SpawnObject()
    {
        int index = isRandomized ? Random.Range(0, locationsToSpawn.Count) : 0;
        if (locationsToSpawn.Count > 0)
        {
            Instantiate(objectToSpawn, locationsToSpawn[index].transform);
        }
    }
}