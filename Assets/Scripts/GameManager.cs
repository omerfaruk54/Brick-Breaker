using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Text scoreText;

    [SerializeField]
    Text livesText;

    int lives = 3;
    int score = 0;

    public bool gameOver;

    [SerializeField]
    GameObject gameOverPanel;
    


    


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;

    }

    public void UpdateLives(int countLives)
    {
        lives += countLives;
        livesText.text = "Lives: " + lives;

        if (lives==0)
        {
            GameOver();
        }
    }

    public void UpdateScore(int _score)
    {
        this.score += _score;
        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        gameOver = true;

        gameOverPanel.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    


}

