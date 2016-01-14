using UnityEngine;
using System.Collections;

public class AlienSpawner : MonoBehaviour {

    public float maxSpawnTimeout;
    public float minSpawnTimeout;

    public GameObject AlienPrefab;

    public GameObject NorthWestSpawnLoc;
    public GameObject SouthWestSpawnLoc;
    public GameObject NorthEastSpawnLoc;
    public GameObject SouthEastSpawnLoc;

    float currentSpawnTimeout;

    public static bool doesAlienExist = false;

	void Start ()
    {
	}
	
	void Update ()
    {
        if (currentSpawnTimeout >= 0 && !doesAlienExist)
        {
            SpawnBonusAlien();
            ResetSpawnTimeout();
        }

        else
            currentSpawnTimeout -= Time.deltaTime;
	}

    void ResetSpawnTimeout()
    {
        currentSpawnTimeout = Random.Range(minSpawnTimeout, maxSpawnTimeout);
    }


    void SpawnBonusAlien()
    {
        int spawnLoc = Random.Range(0, 3);
        Vector3 spawnPos;
        switch (spawnLoc)
        {
            case 0:
                spawnPos = NorthWestSpawnLoc.transform.position;
                break;
            case 1:
                spawnPos = SouthWestSpawnLoc.transform.position;
                break;
            case 2:
                spawnPos = NorthEastSpawnLoc.transform.position;
                break;
            case 3:
                spawnPos = SouthEastSpawnLoc.transform.position;
                break;
            default:
                spawnPos = Vector3.zero;
                break;
        }

        Instantiate(AlienPrefab, spawnPos, Quaternion.identity);
        doesAlienExist = true;
    }

}
