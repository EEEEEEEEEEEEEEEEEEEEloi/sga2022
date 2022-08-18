using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    [SerializeField]
    float MultipleSpeed;
    float horizon;
    float vertical;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    float VitesseBullet = 3.0f;
    float SpawnDist = 2.0f;
    Vector2 direction = new Vector2();
    public GameObject projectile_stocke;
    public int AmmoCount = 1;
    // Start is called before the first frame update
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        direction = Vector2.right;
    }

    public void BulletDestroyed()
    {
        AmmoCount++;
        if (AmmoCount > 1)
            AmmoCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal") * MultipleSpeed;
        vertical = Input.GetAxis("Vertical") * MultipleSpeed;
        if (Mathf.Abs(horizon) > 0 || Mathf.Abs(vertical) > 0) {
            direction.x = horizon;
            direction.y = vertical;
        }

        if (Input.GetButtonDown("Fire1")) {
            if (projectile_stocke == null)
            {
                if (AmmoCount > 0)
                {
                    anim.SetTrigger("Catch");
                    GameObject NewBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                    NewBullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * VitesseBullet;
                    NewBullet.GetComponent<Bullet>().controller_ = this;
                    AmmoCount--;
                }
            }
            else
            {
                anim.SetTrigger("Catch");
                projectile_stocke.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                projectile_stocke.transform.position = transform.position + ((Vector3)direction).normalized * SpawnDist;
                projectile_stocke.GetComponent<Rigidbody2D>().velocity = direction.normalized * VitesseBullet;
                projectile_stocke = null;
            }
              
            
        }
      
    }

    void FixedUpdate()
    {
        

        rigidbody2D.velocity = new Vector2(horizon, vertical);
        anim.SetFloat("velocity_x", rigidbody2D.velocity.x);
          anim.SetFloat("velocity_y", rigidbody2D.velocity.y);
        if(((int)horizon) != 0)
            anim.SetInteger("direction", (int)horizon);
    }

}