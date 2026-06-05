using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public float timer = 60f;

    private UImanager uiManager;

    private bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1f;

        uiManager = FindObjectOfType<UImanager>();

        uiManager.UpdateTimer(timer);
    }

    void Update()
    {
        if (!juegoTerminado)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;

                juegoTerminado = true;

                uiManager.MostrarPantallaGameOver();

                Time.timeScale = 0f;
            }

            uiManager.UpdateTimer(timer);
        }

        if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void TerminarJuego()
    {
        juegoTerminado = true;
    }
}