using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour
{
    public void SetupEasy()
    {
        GameStats.ResetGameStats(GameDifficulty.Easy);
        StartAI();
    }

    public void SetupNormal()
    {
        GameStats.ResetGameStats(GameDifficulty.Normal);
        StartAI();
    }

    public void SetupHard()
    {
        GameStats.ResetGameStats(GameDifficulty.Hard);
        StartAI();
    }

    public void SetupImpossible()
    {
        GameStats.ResetGameStats(GameDifficulty.Impossible);
        StartAI();
    }

    public void StartAI()
    {
        Application.LoadLevel(1);
    }



}
