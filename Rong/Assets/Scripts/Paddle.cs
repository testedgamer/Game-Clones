using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    public float Velocity = 3f;

    public float UpperBounds = 1f;
    public float LowerBounds = -1f;

    public KeyCode Up = KeyCode.W;
    public KeyCode Down = KeyCode.S;

    public bool IsAI;

    public static bool GameWon = false;
    public static GameObject AIBall = null;
    
    void Update()
    {
        if (!GameWon)
        {
            if (IsAI)
            {
                AIMovement();
            }
            else
                PlayerMovement();
        }
    }

    void PlayerMovement()
    {
        if (Input.GetKey(Up))
        {
            transform.Translate(0, Velocity * Time.deltaTime, 0);
        }

        if (Input.GetKey(Down))
        {
            transform.Translate(0, Velocity * -1 * Time.deltaTime, 0);
        }

        // Upper and lower bounds
        if (transform.position.y > UpperBounds)
        {
            Vector3 pos = transform.position;
            pos.y = UpperBounds;
            transform.position = pos;
        }

        else if (transform.position.y < LowerBounds)
        {
            Vector3 pos = transform.position;
            pos.y = LowerBounds;
            transform.position = pos;
        }
    }

    void AIMovement()
    {
        if (AIBall != null)
        {
            //Debug.Log("AI Update");
            Vector3 pos = transform.position;
            pos.y = AIBall.transform.position.y;
            transform.position = pos;
        }

    }

    public static void SetupAI(GameObject invisibleBall)
    {
        AIBall = invisibleBall;
    }
    public static void ClearAI()
    {
        AIBall = null;
    }



}
