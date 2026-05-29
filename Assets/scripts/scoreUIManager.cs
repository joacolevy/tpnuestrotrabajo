using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreUIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_score;

    public int score = 0;

    void Start()
    {
        txt_score.text = "Puntos: 0";
    }

    public void AddPointAndUpdateScore()
    {
        score += 5;

        if(score >= 10)
        {
            txt_score.text = "Ganaste";
        }
        else
        {
            txt_score.text = "Puntos: " + score;
        }
    }
}