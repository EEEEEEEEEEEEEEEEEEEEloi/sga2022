using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public controller controller_;

    private void OnBecameInvisible()
    {
        controller_.BulletDestroyed();
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("avalable"))
        {
            collision.transform.position = new Vector2(400, 400);
            controller_.projectile_stocke = collision.gameObject;
            controller_.BulletDestroyed();
            Bullet.Destroy(gameObject);
        }
        
    }
}
