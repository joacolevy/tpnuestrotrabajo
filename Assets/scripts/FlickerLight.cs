using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{
    public Light luz;
    public float tiempoMin = 0.05f;
    public float tiempoMax = 0.3f;

    void Start()
    {
        if (luz == null)
            luz = GetComponent<Light>();

        StartCoroutine(Titilar());
    }

    IEnumerator Titilar()
    {
        while (true)
        {
            luz.enabled = !luz.enabled;

            float tiempo = Random.Range(tiempoMin, tiempoMax);
            yield return new WaitForSeconds(tiempo);
        }
    }
}