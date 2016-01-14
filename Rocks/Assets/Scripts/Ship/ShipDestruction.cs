using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShipDestruction : MonoBehaviour
{
    public Vector2 startingPos;
    public Text GameOverText; 

    void OnCollisionEnter2D(Collision2D col)
    {
        string colTag = col.gameObject.tag;

        if (colTag == "BonusAlien" || colTag == "Rock")
        {
            OnDeath();
        }            
    }

    void OnDeath()
    {
        if (GameStats.playerLives == 0)
        {
            GameOverText.enabled = true;
            Time.timeScale = 0;
        }
        else
            GameStats.playerLives--;
    }


}
