using UnityEngine;

public class INTERACTIVEAREA : MonoBehaviour
{
    private UImanager uiManager;
    private gamemanager gameManager;

    private int score = 0;

    void Awake()
    {
        uiManager = FindObjectOfType<UImanager>();
        gameManager = FindObjectOfType<gamemanager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            score += 3; // suma 3 puntos

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);

            if (score >= 9) // 3 objetos x 3 puntos
            {
                uiManager.scoreText.text = "¡Ganaste!";
                gameManager.timer = 0;
            }
        }
    }
}