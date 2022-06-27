using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int score;
    public TMP_Text scoreText;
    public static GameManager Instace;


    public GameObject GMPanel;
    public TMP_Text currentText;
    public TMP_Text highscoreText;
    public Button restartBt;

    private void Awake()
    {
        if(Instace == null)
        {
            Instace = this;
        }
    }
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        GMPanel.SetActive(false);
        restartBt.onClick.RemoveAllListeners();
        restartBt.onClick.AddListener(RestartLvl);

        currentText.text = PlayerPrefs.GetInt("Score").ToString();
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
    }
    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString(); 
    }

    public void GameOver()
    {
        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }

        PlayerPrefs.SetInt("Score", score);

        currentText.text = PlayerPrefs.GetInt("Score").ToString();
        highscoreText.text = PlayerPrefs.GetInt("Highscore").ToString();

        GMPanel.SetActive(true);
    }

    public void RestartLvl()
    {
        SceneManager.LoadScene("Gameplay");

    }
}
