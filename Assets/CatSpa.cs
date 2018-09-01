using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpa : MonoBehaviour
{
	public static int randomIndex;
    public float spawnDelay = .3f;

    public GameObject cat;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;
     void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCat();
            nextTimeToSpawn = Time.time + spawnDelay;

        }
    }

    void SpawnCat()
    {
        randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(cat,spawnPoint.position,spawnPoint.rotation);

    }


}

