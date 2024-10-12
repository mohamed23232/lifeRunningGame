using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
 

    private int Score = 0;
    public Text ScoreText;
    public GameObject GameOverScreen;

    void Start()
    {
       Score = 0;
       ScoreText.text = Score.ToString();
    }

    [ContextMenu("Increase Score")]
    public void IncreaseScore(int addition)
    {
        // check if the game is over
        if (GameOverScreen.activeSelf == false)
        {

            Score += addition;
            ScoreText.text = Score.ToString();
        }
    }
    public void GameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
