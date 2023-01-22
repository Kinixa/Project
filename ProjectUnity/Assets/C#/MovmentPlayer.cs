using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{
    public Transform orientation;
    public float moveSpeed;
    public float normalSpeed;
    public float slowSpeed;
    public KeyCode slowKey = KeyCode.LeftShift;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    public Rigidbody rb;


    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }
    private void Update()
    {


        myInput();
        whichMovement();

    }

    private void whichMovement()
    {
        if (Input.GetKey(slowKey))
        {
            moveSpeed = slowSpeed;
            rb.AddForce(moveDirection / slowSpeed, ForceMode.Force);

        }
        else
        {
            moveSpeed = 20f;

        }
    }




    private void FixedUpdate()
    {
        Move();
    }



    private void myInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    public void Move()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(-rb.velocity * 2 + moveDirection * moveSpeed, ForceMode.Force);
    }

}