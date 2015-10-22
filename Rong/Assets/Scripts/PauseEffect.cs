using UnityEngine;
using System.Collections;

public class PauseEffect : MonoBehaviour
{
    // This bugs me on  ho
    public KeyCode PauseKey;
    private bool IsPaused = false;

	void Update ()
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
