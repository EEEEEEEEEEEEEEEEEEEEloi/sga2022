using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetGrimpable : MonoBehaviour
{
    [SerializeField] int height = 1;
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(!(collision.gameObject.GetComponent<controller>().playerHeight > height))
            {
                collision.gameObject.GetComponent<controller>().playerHeight = 0;
                GetComponent<BoxCollider2D>().isTrigger = false;
            }
          

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<controller>().playerHeight == height - 1 || collision.gameObject.GetComponent<controller>().playerHeight == height + 1)
            {
                GetComponent<BoxCollider2D>().isTrigger = true;
                collision.gameObject.GetComponent<controller>().playerHeight = height;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<controller>().playerHeight == height - 1 || collision.gameObject.GetComponent<controller>().playerHeight == height + 1)
            {
                GetComponent<BoxCollider2D>().isTrigger = true;
                collision.gameObject.GetComponent<controller>().playerHeight = height;
            }
        }
    }
}
