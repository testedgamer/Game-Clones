using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreBoard : MonoBehaviour {

    public Text Player1ScoreUI;
    public Text Player2ScoreUI;
	
	void Update ()
    {
        Player1ScoreUI.text = GameStats.Player1Score.ToString();
        Player2ScoreUI.text = GameStats.Player2Score.ToString();
	}
}
