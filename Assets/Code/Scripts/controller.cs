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
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizon = Input.GetAxis("Horizontal") * MultipleSpeed;
        vertical = Input.GetAxis("Vertical") * MultipleSpeed;
    }

    void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(horizon, vertical);
    }

}
