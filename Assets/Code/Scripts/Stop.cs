using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            //GetComponent<BoxCollider2D>().isTrigger = false;
        }

    }
}