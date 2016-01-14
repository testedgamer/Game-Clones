using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class LevelSpawner : MonoBehaviour
{
    public GameObject SmallRock;
    public GameObject MediumRock;
    public GameObject LargeRock;
    public GameObject ExtraLargeRock;

    public TextAsset levels;

    public Sprite[] RockSprites;

    public float spawningForce;

    public GameObject NorthSpawnPoint;
    public GameObject SouthSpawnPoint;
    public GameObject EastSpawnPoint;
    public GameObject WestSpawnPoint;

    // TODO: Make relative
    string filepath = @"D:\Projects\Angry Dragon\Game Clones\Rocks\Assets\Levels.txt";
    int currentLevelIndex = 0;
    public static int rocksCurrentlySpawned = 0;

    void Start ()
    {
	}

    void Update()
    {
        if (rocksCurrentlySpawned == 0)
            SpawnRocks();
    }

    public void SpawnRocks()
    {
        //rocksCurrentlySpawned = levels[currentLevelIndex].Length;
        //foreach (char rockType in levels[currentLevelIndex])
        //{
        //    // Find a spawn location
        //    Vector3 spawnLocation;

        //    int randomSpawnLoc = Random.Range(0, 3);
        //    switch (randomSpawnLoc)
        //    {
        //        case 0:
        //            spawnLocation = NorthSpawnPoint.transform.position;
        //            break;
        //        case 1:
        //            spawnLocation = EastSpawnPoint.transform.position;
        //            break;
        //        case 2:
        //            spawnLocation = SouthSpawnPoint.transform.position;
        //            break;
        //        case 3:
        //            spawnLocation = WestSpawnPoint.transform.position;
        //            break;
        //        default:
        //            spawnLocation = Vector3.zero;
        //            break;
        //    }



        //    // Init Spawn Rock
        //    GameObject spawnedRock;

        //    switch (rockType)
        //    {
        //        case 's':
        //            spawnedRock = (GameObject) Instantiate(SmallRock, spawnLocation, Quaternion.identity);
        //            break;
        //        case 'm':
        //            spawnedRock = (GameObject)Instantiate(MediumRock, spawnLocation, Quaternion.identity);
        //            break;
        //        case 'l':
        //            spawnedRock = (GameObject)Instantiate(LargeRock, spawnLocation, Quaternion.identity);
        //            break;
        //        case 'x':
        //            spawnedRock = (GameObject)Instantiate(ExtraLargeRock, spawnLocation, Quaternion.identity);
        //            break;
        //        default:
        //            spawnedRock = (GameObject)Instantiate(SmallRock, spawnLocation, Quaternion.identity);
        //            break;
        //    }

        //    // Determine Rock Texture
        //    int rockTexture = Random.Range(0, RockSprites.Length - 1);
        //    spawnedRock.GetComponent<SpriteRenderer>().sprite = RockSprites[rockTexture];

        //    // Shoot Rock, no pew's
        //    Rigidbody2D rockphysics = spawnedRock.GetComponent<Rigidbody2D>();
        //    Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        //    rockphysics.AddForce(direction * spawningForce, ForceMode2D.Impulse);
        //}

        //currentLevelIndex++;
    }
}


