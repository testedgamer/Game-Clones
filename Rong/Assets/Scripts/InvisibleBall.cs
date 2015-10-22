using UnityEngine;
using System.Collections;

public class InvisibleBall : MonoBehaviour
{
    public float UpperBounds;
    public float LowerBounds;

    public float RightBounds;

    public float XVelocity;

    public float YVelocity_Scale = 1; 

    public float YVelocity_Easy;
    public float YVelocity_Normal;
    public float YVelocity_Hard;


    public static bool inverse = false;

    Vector2 Velocity;

    void Start()
    {
        Velocity = new Vector2() { x = XVelocity };

        switch (GameStats.CurrentGameDifficulty)
        {
            case GameDifficulty.Easy:
                Velocity.y = RandomYSpeed(YVelocity_Easy);
                break;
            case GameDifficulty.Normal:
                Velocity.y = RandomYSpeed(YVelocity_Normal);
                break;
            case GameDifficulty.Hard:
                Velocity.y = RandomYSpeed(YVelocity_Hard);
                break;
        }

        if (inverse)
        {
            Velocity.y *= -1;
            inverse = false;
        }
    }

    void Update()
    {

        if (transform.position.y > UpperBounds || transform.position.y < LowerBounds)
        {
            Velocity.y *= -1;
        }
        else if (transform.position.x > RightBounds)
        {
            Paddle.ClearAI();
            Destroy(gameObject);
        }

        transform.Translate(Velocity.x * Time.deltaTime, Velocity.y * Time.deltaTime, 0);
        
    }

    float RandomYSpeed(float baseValue)
    {
        return Random.Range(baseValue - YVelocity_Scale, baseValue + YVelocity_Scale);
    }

}