using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;

    public GameObject winPanel;
    public GameObject gameOverPanel;

    public void UpdateScore(int score)
    {
        scoreText.text = "Puntos: " + score;
    }

    public void UpdateTimer(float time)
    {
        int seconds = Mathf.CeilToInt(time);
        timerText.text = "00:" + seconds.ToString("00");
    }

    public void MostrarPantallaWin()
    {
        winPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}