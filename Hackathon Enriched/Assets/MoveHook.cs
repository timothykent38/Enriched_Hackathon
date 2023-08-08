using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingingHook2D : MonoBehaviour
{
    public Transform minPosition;
    public Transform maxPosition;
    public float swingSpeed = 1.0f;

    private Rigidbody2D rb;
    private bool isMovingRight = true;
    bool isStopped = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        // check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStopped = true;
            rb.velocity = Vector2.zero; // stop movement
            swingSpeed = 0;
            // play animation
        }

        if (Input.GetKeyUp(KeyCode.Space)) {
            isStopped = false;
            //rb.velocity = Vector2.zero; // stop movement
            swingSpeed = 3.0f;

        }

 

        if (isMovingRight)
        {
            if (transform.position.x >= maxPosition.position.x)
            {
                isMovingRight = false;
            }
        }
        else
        {
            if (transform.position.x <= minPosition.position.x)
            {
                isMovingRight = true;
            }
        }

        float direction = isMovingRight ? 1.0f : -1.0f;
        rb.velocity = new Vector2(swingSpeed * direction, rb.velocity.y);
    }

    
}
