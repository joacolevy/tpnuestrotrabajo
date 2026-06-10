using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public float timer = 60f;

    private UImanager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UImanager>();
        uiManager.UpdateTimer(timer);
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                timer = 0;
            }

            uiManager.UpdateTimer(timer);
        }
    }
}