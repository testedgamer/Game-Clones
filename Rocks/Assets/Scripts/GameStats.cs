using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStats : MonoBehaviour
{
    public static int highScore = 0;
    public static int currentScore = 0;

    public static int playerLives = 3;

    public Text HighScoreText;
    public Text ScoreText;
    
	void Update ()
    {
        HighScoreText.text = highScore.ToString();
        ScoreText.text = currentScore.ToString();	
	}
}
