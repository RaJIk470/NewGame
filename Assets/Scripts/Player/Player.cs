using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;
    Vector2 _velocity;
    Rigidbody2D _rigidbody;
    Transform _transform;
    Animator _animator;

    void Start()
    {
        _transform = GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        _rigidbody.velocity = _velocity;
    }

    public void MoveLeft()
    {
        _velocity = new Vector2(-1, _velocity.y) * speed;
        _animator.SetInteger("AnimState", 1);
    }
    public void MoveRight()
    {
        _velocity = new Vector2(1, _velocity.y) * speed;
        _animator.SetInteger("AnimState", 2);
    }
    public void MoveUp()
    {
        _velocity = new Vector2(_velocity.x, 1) * speed;
        _animator.SetInteger("AnimState", 3);
    }
    public void MoveDown()
    {
        _velocity = new Vector2(_velocity.x, -1) * speed;
        _animator.SetInteger("AnimState", 4);
    }
    public void Idle()
    {
        _velocity = Vector2.zero;
        _animator.SetInteger("AnimState", 0);
    }
}
