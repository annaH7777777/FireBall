using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    public Text highScoreText;
    //public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int highScore = PlayerPrefs.GetInt("HIGHSCORE");

        if (ScoreScript.score > highScore)
        {
            PlayerPrefs.SetInt("HIGHSCORE", ScoreScript.score);
            highScoreText.text = "Game Over!" + "\n" + "Congrats your score" + ScoreScript.score + " is high score";
        }
        else
        {
            highScoreText.text = "Game Over!" + "\n" + "Your score is " + ScoreScript.score + "." + "\n" + "High Score is " + highScore + "\n" + "Can you beat it?";
        }
    }
    public void StartGame()
    {
        GameManager.gameOver = false;
        ScoreScript.score = 0;
        SceneManager.LoadScene("Main");
    }
}
