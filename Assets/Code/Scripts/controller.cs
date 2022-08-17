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
    public GameObject projectile_stocke;
    // Start is called before the first frame update
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal") * MultipleSpeed;
        vertical = Input.GetAxis("Vertical") * MultipleSpeed;

        if (Input.GetButtonDown("Fire1")) {
            anim.SetTrigger("Catch");
            GameObject NewBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            NewBullet.GetComponent<Rigidbody2D>().velocity = new Vector3 (2, 0, 0);
            NewBullet.GetComponent<Bullet>().controller_ = this;
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
