using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendreinvisible : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriterenderer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("avalable"))
        {
            spriterenderer.enabled = false;
        }
    }
}
