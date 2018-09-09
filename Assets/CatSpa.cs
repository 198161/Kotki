using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpa : MonoBehaviour
{
    public static int whichAvatarIsOn = 0;

    public static int randomIndex;
    public float spawnDelay = .3f;
    public Sprite basicSprite;
    public Sprite catSprite0;
    public Sprite catSprite1;
    public Sprite catSprite2;
    public Sprite catSprite3;
    public Sprite catSprite4;
    public Sprite catSprite5;
    public Sprite catSprite6;

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
        GameObject Clone;


        Clone = (Instantiate(cat, spawnPoint.position, spawnPoint.rotation)) as GameObject;

        Clone.GetComponent<SpriteRenderer>().sprite = catSprite0;


    }

    public void SwitchAvatar()
    {


        if (whichAvatarIsOn == 0)
        {
            basicSprite = catSprite0;
        }
        else if (whichAvatarIsOn == 1)
        {
            basicSprite = catSprite1;
        }
        else if (whichAvatarIsOn == 2)
        {
            basicSprite = catSprite2;
        }
        else if (whichAvatarIsOn == 3)
        {
            basicSprite = catSprite3;
        }
        else if (whichAvatarIsOn == 4)
        {
            basicSprite = catSprite4;
        }
        else if (whichAvatarIsOn == 5)
        {
            basicSprite = catSprite5;
        }
        else if (whichAvatarIsOn == 6)
        {
            basicSprite = catSprite6;
        }
        else
        {
            basicSprite = catSprite0;
        }
    }
}
