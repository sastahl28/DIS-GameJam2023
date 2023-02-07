using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Legos : MonoBehaviour
{
    public float spawnWidth = 1;
    public float spawnRate = 1;

    public GameObject[] legos;
  

    private float lastSpawnTime = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawnTime + 1 / spawnRate < Time.time)
        {
            lastSpawnTime = Time.time;
            Vector3 spawnPosition = transform.position;
            spawnPosition += new Vector3(Random.Range(-spawnWidth, spawnWidth), 0, 0);
            int legoPick = Random.Range(0, legos.Length);
            Instantiate(legos[legoPick], spawnPosition, Quaternion.identity);
        }
    }
}
