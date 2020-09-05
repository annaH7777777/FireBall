using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public static bool gameOver = false;
    public GameObject gameOverPanel;
    public GameObject gameScene;
    public Text highScoreText;
    public GameObject ball;


    // Start is called before the first frame update
    void Start()
    {
       
        scoreText.text =""+ score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "" + score;
    }
    public void GameOver()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
        gameScene.SetActive(false);
        int highScore = PlayerPrefs.GetInt("HIGHSCORE");
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HIGHSCORE", score);
            highScoreText.text = "Game Over!" + "\n" + "Congrats your score" + score +" is high score";



        }
        else
        {
            highScoreText.text = "Game Over!"+ "\n" +"Your score is "+score+ "." + "\n" +"High Score is " + highScore + "\n" + "Can you beat it?";
        }
    }
}
