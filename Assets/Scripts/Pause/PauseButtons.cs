using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtons : MonoBehaviour
{
    public Canvas canvas;
    public void Resume()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }
}
