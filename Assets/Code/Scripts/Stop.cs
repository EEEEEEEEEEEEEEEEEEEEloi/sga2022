using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.CompareTag("Wall"))
        {
            gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        }

    }
}