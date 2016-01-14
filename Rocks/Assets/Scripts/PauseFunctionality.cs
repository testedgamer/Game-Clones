using UnityEngine;
using System.Collections;

public class PauseFunctionality : MonoBehaviour
{
    public KeyCode PauseKey;
    public static bool IsPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(PauseKey))
        {
            if (!IsPaused)
            {
                Time.timeScale = 0f;
                IsPaused = true;
            }

            else
            {
                Time.timeScale = 1f;
                IsPaused = false;
            }

        }
    }
}
