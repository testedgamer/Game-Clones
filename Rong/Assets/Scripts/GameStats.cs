using UnityEngine;
using System.Collections;

public static class GameStats
{
    public static int Player1Score = 0;
    public static int Player2Score = 0;
    public static int WinningScore = 7;

    //public static GameDifficulty CurrentGameDifficulty = GameDifficulty.Easy;
    public static GameDifficulty CurrentGameDifficulty = GameDifficulty.Hard;

    public static bool GameWon = false;

    public static string WinningPlayer = null;

    public static void ResetGameStats(GameDifficulty difficulty)
    {
        Player1Score = 0;
        Player2Score = 0;
        CurrentGameDifficulty = difficulty;
        WinningPlayer = null;
    }
}

public enum GameDifficulty
{
    Easy,
    Normal,
    Hard,
    Impossible
}

