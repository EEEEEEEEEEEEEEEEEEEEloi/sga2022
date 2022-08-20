using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendreVisible : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriterenderer;
    [SerializeField] SpriteRenderer fleche;
    [SerializeField] SpriteRenderer barre;

    private void Start()
    {
        if (barre != null)
        {
            barre.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                spriterenderer.enabled = false;
                if (fleche != null)
                {
                    fleche.enabled = true;
                    barre.enabled = false;
                }
                //spriterenderer.enabled = false;
                //if (barre != null)
                {
                    //barre.enabled = true;
                }
            }
        }
    }

}
