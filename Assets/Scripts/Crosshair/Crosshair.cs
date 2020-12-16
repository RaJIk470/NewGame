using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public Vector3 mousePosition;
    Transform _crosshairTransform;
    void Start()
    {
        _crosshairTransform = GetComponent<Transform>();
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _crosshairTransform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
    }
}
