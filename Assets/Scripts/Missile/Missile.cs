using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    float _damage;
    public float liveTime = 0.1f;
    void Start()
    {
        _damage = GameObject.Find("Weapon").GetComponent<Weapon>().damage;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Debug.Log("easy dd");
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        liveTime -= Time.deltaTime;
        if (liveTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
