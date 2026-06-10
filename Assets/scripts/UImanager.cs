using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float time)
    {
        int seconds = Mathf.CeilToInt(time);
        timerText.text = "00:" + seconds.ToString("00");
    }
}