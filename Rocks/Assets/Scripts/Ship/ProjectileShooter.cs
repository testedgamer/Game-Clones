using UnityEngine;
using System.Collections;

public class ProjectileShooter : MonoBehaviour
{
    public float projForce;
    public GameObject ProjectileObject;
    public KeyCode fireKey;
    public int projLimit;

    public static int currentProjCount = 0;
    GameObject projSpawningPoint;
    GameObject player;

	void Start ()
    {
        projSpawningPoint = GameObject.Find("Ship/ProjSpawnPoint");
        player = GameObject.Find("Ship");
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(fireKey) && currentProjCount < projLimit && !PauseFunctionality.IsPaused)
        {
            GameObject spawnedObj = Instantiate(ProjectileObject, projSpawningPoint.transform.position, Quaternion.identity) as GameObject;
            Vector2 projVelocity = (Vector2)(player.transform.right * projForce) + player.GetComponent<Rigidbody2D>().velocity;

            Rigidbody2D rb = spawnedObj.GetComponent<Rigidbody2D>();
            rb.AddForce(projVelocity, ForceMode2D.Impulse);

            currentProjCount++;
        }

	}
}
