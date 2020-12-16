﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Canvas canvas;
    
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false; // когда стартуем вырубаем inventory
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.I))
        {
            canvas.enabled = !canvas.enabled;
        } 
    }
}
