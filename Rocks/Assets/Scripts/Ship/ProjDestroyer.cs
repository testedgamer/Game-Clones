using UnityEngine;
using System.Collections;

public class ProjDestroyer : MonoBehaviour
{
    public float projLifeTime;
    float currentTimeAlive = 0;

	void Update ()
    {
        if (currentTimeAlive >= projLifeTime)
            DestroyProj();
        else
            currentTimeAlive += Time.deltaTime;
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Rock" || col.gameObject.tag == "BonusAlien")
        {
            DestroyProj();
        }
    }

    void DestroyProj()
    {
        Destroy(this.gameObject);
        ProjectileShooter.currentProjCount--;
    }
}
