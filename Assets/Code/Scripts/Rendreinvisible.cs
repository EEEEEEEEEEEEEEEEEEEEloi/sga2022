using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rendreinvisible : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriterenderer;
    [SerializeField] SpriteRenderer Visible;
    [SerializeField] SpriteRenderer Vivivivisible;
    private void Start()
    {
        if (Visible != null)
        {
            Visible.enabled = false;
        }
        if (Vivivivisible != null)
        {
            Vivivivisible.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("avalable"))
        {
            spriterenderer.enabled = false;
            if (Visible != null)
            {
                Visible.enabled = true;
            }
            spriterenderer.enabled = false;
            if (Vivivivisible != null)
            {
                Vivivivisible.enabled = true;
            }
        }
    }
}