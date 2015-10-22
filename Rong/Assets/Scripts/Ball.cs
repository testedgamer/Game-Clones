using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float MovementSpeed;
    public float UpperBounds;
    public float LowerBounds;

    public float LeftBounds;
    public float RightBounds;

    public GameObject InvisibleBallPrefab;

    Vector2 Velocity;
    Vector3 StartingPosition;
    AudioSource boop;

	void Start ()
    {
        StartingPosition = transform.position;
        boop = gameObject.GetComponent<AudioSource>();
        ResetBall();
	}

    void Update()
    {
        // Bounce off of top and bottom
        if (transform.position.y > UpperBounds || transform.position.y < LowerBounds)
        {
            boop.Play();
            Velocity.y *= -1;
        }

        if (transform.position.x < LeftBounds)
            Player1Scores();

        if (transform.position.x > RightBounds)
            Player2Scores();

        else
            transform.Translate(Velocity.x * Time.deltaTime, Velocity.y * Time.deltaTime, 0);
	}

    void ResetBall()
    {
        transform.position = StartingPosition;

        // Pick a random direction
        Velocity = new Vector2(RandomAxis(), RandomAxis());

    }

    void Player1Scores()
    {
        GameStats.Player1Score++;

        if (GameStats.WinningScore < GameStats.Player1Score)
            GameStats.WinningPlayer = "Player1 Wins!";

        ResetBall();
    }

    void Player2Scores()
    {
        GameStats.Player2Score++;

        if (GameStats.WinningScore < GameStats.Player2Score)
            GameStats.WinningPlayer = "Player2 Wins!";

        ResetBall();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Velocity.x *= -1;
        boop.Play();

        if(Paddle.AIBall == null)
        {
            GameObject invisBall = (GameObject) Instantiate(InvisibleBallPrefab, transform.position, transform.localRotation);
            InvisibleBall.inverse = Velocity.y < 0;
            Paddle.SetupAI(invisBall);
        }
    }

    float RandomAxis()
    {
        Random.seed = (int)Time.deltaTime;

        float randomValue = Random.Range(0, 50f);
        if (randomValue <= 25)
            return -1;
        else
            return 1;
    }



}
