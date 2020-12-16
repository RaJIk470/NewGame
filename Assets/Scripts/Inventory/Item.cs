using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// подбор мыла с пола

public class Item : MonoBehaviour
{
    public int index = 0;
    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.transform.tag == "Player")
        {
            //obj.GetComponent<Items>().AddItem(index); // подбор предмета
            Destroy(gameObject);
        }
    }
}
