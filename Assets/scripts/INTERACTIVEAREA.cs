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
            if (other.name == "Objeto1")
                score += 1;
            else if (other.name == "Objeto2")
                score += 1;
            else if (other.name == "Objeto3")
                score += 1;
            else if (other.name == "Objeto4")
                score += 1;
            else if (other.name == "Objeto5")
                score += 2;
            else if (other.name == "Objeto6")
                score += 2;
            else if (other.name == "Objeto7")
                score += 2;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);

            if (score >= 10)
            {
                uiManager.MostrarPantallaWin();

                gameManager.TerminarJuego();

                Time.timeScale = 0f;
            }
        }
    }
}