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
            score++;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);

            if (score >= 5)
            {
                uiManager.MostrarPantallaWin();

                gameManager.TerminarJuego();

                Time.timeScale = 0f;
            }
        }
    }
}