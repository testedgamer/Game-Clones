using UnityEngine;
using System.Collections;

public class RockBreakup : MonoBehaviour
{
    public GameObject LowerRock;
    public GameObject BreakupTemplate;

    public int scoreValue;

    public float globalBreakupVelocityIncrease;

    // Bug: this needs to be dyanmic with the Level Spawner
    public Sprite[] rockTextures;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Projectile")
        {
            BreakupRock();
            GameStats.currentScore += scoreValue;
            Destroy(this.gameObject);
        }
    }

    void BreakupRock()
    {
        if (LowerRock != null)
        { 
            GameObject breakupInstance = Instantiate(BreakupTemplate, transform.position, transform.rotation) as GameObject;

            CreateSubrock(GameObject.Find("RockBreakup1").transform);
            CreateSubrock(GameObject.Find("RockBreakup2").transform);
            CreateSubrock(GameObject.Find("RockBreakup3").transform);

            Debug.Log("Breakup of object: " + name);

            Destroy(breakupInstance);
            Destroy(this.gameObject);
        }

    }

    void CreateSubrock(Transform templateDynamics)
    {
        Rigidbody2D physics = GetComponent<Rigidbody2D>();
        GameObject subRock = Instantiate(LowerRock, templateDynamics.position, transform.rotation) as GameObject;
        Rigidbody2D subRockPhys = subRock.GetComponent<Rigidbody2D>();

        // Rocks need physics to escape from breakup location
        subRockPhys.velocity = (Vector2)(templateDynamics.transform.right * globalBreakupVelocityIncrease) + physics.velocity;

        int randTextureIndex = Random.Range(0, rockTextures.Length - 1);

        subRockPhys.GetComponent<SpriteRenderer>().sprite = rockTextures[randTextureIndex];
    }


}
