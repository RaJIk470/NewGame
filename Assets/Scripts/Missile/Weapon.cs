using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject missilePrefab;
    public float missileSpeed = 1;
    public float damage = 20;
    public Crosshair _crosshair;
    Transform _crosshairTransform;
    Vector2 shootingDirection;
    void Start()
    {
        _crosshairTransform = _crosshair.GetComponent<Transform>();
    }
    public void Shoot(Transform playerPosition)
    {
        shootingDirection = _crosshairTransform.localPosition.normalized;
        GameObject fireBall = Instantiate(missilePrefab, playerPosition.position, Quaternion.identity);
        fireBall.GetComponent<Rigidbody2D>().velocity = shootingDirection * missileSpeed;
        fireBall.transform.Rotate(0, 0, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
    }
}
