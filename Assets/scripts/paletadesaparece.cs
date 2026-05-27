﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INTERACTIVEAREA : MonoBehaviour
{
    public scoreUIManager scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision col)
    {
    if(col.gameObject.CompareTag("picable"))
    {
     Destroy(col.gameObject);   
     scoreUI.AddPointAndUpdateScore();
    }
    }
}