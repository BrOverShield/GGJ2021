using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    float x;
    float y;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        rb.velocity = transform.forward * y*10+transform.right*x*10;
        float xx = 5 * Input.GetAxis("Mouse X");
        float yy = 5 * -Input.GetAxis("Mouse Y");
        this.gameObject.transform.Rotate(yy, xx, 0);
    }
}
