using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INTERACTIVEAREA : MonoBehaviour
{
    public scoreUIManager scoreUI;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("picable"))
        {
            Destroy(col.gameObject);

            scoreUI.AddPointAndUpdateScore();
        }
    }
}