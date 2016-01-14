using UnityEngine;
using System.Collections;

public class BonusAlien : MonoBehaviour
{
    public int movementPace;
    public int totalBonus;

    public float upperHorziontalBounds;
    public float lowerHorziontalBounds;

	void Start ()
    {
        Rigidbody2D physics = GetComponent<Rigidbody2D>();
        physics.AddForce(new Vector2(spawnDirection() * movementPace, 0), ForceMode2D.Force);
	}
	
	void Update ()
    {
        if (transform.position.x > upperHorziontalBounds || transform.position.x < lowerHorziontalBounds)
            Destroy(this.gameObject);
	}

    int spawnDirection()
    {
        if (transform.position.x < 0)
            return 1;
        else
            return -1;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            Destroy(this.gameObject);
            GameStats.currentScore += totalBonus;
        }
    }


}
