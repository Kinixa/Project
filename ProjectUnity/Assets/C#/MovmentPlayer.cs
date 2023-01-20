using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per 
    void Update()
    {
        float hdirection;
        float vdirection;
        if ((hdirection = Input.GetAxis("Horizontal")) !=0)
        {
           rb.AddForce(hdirection * Time.deltaTime * speed, 0, 0);
        }

        if ((vdirection = Input.GetAxis("Vertical")) !=0)
        {
           rb.AddForce( 0, 0, vdirection * Time.deltaTime * speed);
        }
    }
}
