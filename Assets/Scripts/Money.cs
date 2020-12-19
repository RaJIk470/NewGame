using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Money : MonoBehaviour
{
    public Text _moneycount;
    public void Start()
    {
        _moneycount = GameObject.FindWithTag("Score").GetComponent<Text>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            _moneycount.text = (int.Parse(_moneycount.text.ToString()) + 1).ToString();
        }
    }
}
