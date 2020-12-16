using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;
    //public GameObject missile;
   // public float missileSpeed = 1;
    Rigidbody2D _rigidbody;
    Transform _transform;
    Animator _animator;
    Transform _crosshairTransform;
    Weapon _weapon;
    Vector2 _movement;
    private void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _weapon = GameObject.Find("Weapon").GetComponent<Weapon>();
        _crosshairTransform = _transform.Find("Crosshair");
    }   
    private void Update()
    {
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //_crosshairTransform.position = new Vector3(mousePosition.x, mousePosition.y, 0);
        //Vector2 shootingDirection = _crosshairTransform.localPosition.normalized;
        //Debug.Log(shootingDirection);
        if (Input.GetButtonDown("Fire1"))
        {
            _weapon.Shoot(_transform);
        }

    }
    void FixedUpdate()   
    {
        _movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        _animator.SetFloat("Horizontal", _movement.x);
        _animator.SetFloat("Vertical", _movement.y);
        _animator.SetFloat("Magnitude", _movement.magnitude);
        _rigidbody.velocity = _movement;
    }

}
