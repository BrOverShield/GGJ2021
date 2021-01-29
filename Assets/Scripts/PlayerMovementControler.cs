using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementControler : MonoBehaviour
{
    float x;
    float y;
    Rigidbody rb;
    public float speed = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        x = 0.0f;
        y = 0.0f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        rb.velocity = transform.forward * y*speed+transform.right*x*speed;
    }
}
