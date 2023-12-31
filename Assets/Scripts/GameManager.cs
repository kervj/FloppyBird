using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject loseUI;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScore;

    public void StartGame()
    {
        Time.timeScale = 1;
    }

    private void ShowLoseUI()
    {
        loseUI.SetActive(true);
    }

    public void RepeatGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void OnGameOver()
    {
        ShowLoseUI();
        Time.timeScale = 0;        
        int score = PlayerPrefs.GetInt("bestScore");

        if (points > score){
            PlayerPrefs.SetInt("bestScore", points);
        }

        int scoreFinal = PlayerPrefs.GetInt("bestScore");
        bestScore.text = scoreFinal.ToString();

    }

    public void UpdateScore()
    {
        points++;
        scoreText.text = points.ToString();
        Debug.Log(points);
    }
}
