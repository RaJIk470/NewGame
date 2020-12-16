using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    Transform _transform;
    
    void Start()
    {
        _transform = Camera.main.transform;
    }

    void Update()
    {
        _transform.position = new Vector3(Player.position.x, Player.position.y, _transform.position.z);
    }
}
