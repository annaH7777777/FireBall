using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public Text scoreText;
    public static bool gameOver = false;
    public static Text highScoreText;
    public GameObject ball;
    public float startDelay;
    public float spawnInterval;
    public Transform ballFactoryPoint;
    public GameObject ballPrefab;
    public float ballForce;



    // Start is called before the first frame update
    void Start()
    {
        scoreText.text =""+ ScoreScript.score;
        InvokeRepeating("Fall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Fall()
    {
        if (!gameOver)
        {
            ball = Instantiate(ballPrefab, ballFactoryPoint.position, ballFactoryPoint.rotation);
            Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
            rb.AddForce(ballFactoryPoint.up * ballForce, ForceMode2D.Impulse);
        }
    }
    public void UpdateScore(int points)
    {
        ScoreScript.score += points;
        scoreText.text = "" + ScoreScript.score;
    }
    public void GameOver()
    {
        gameOver = true;
        SceneManager.LoadScene("GameOverScene");
    }
}
