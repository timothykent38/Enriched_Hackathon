using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MoveHook : MonoBehaviour
{
    public int maxX = 23;
    public int minX = 13;
    public float hookSpeed = 2f;
    public float moveSpeed = 2f;
    public int top = 15;
    public int bottom = 10;

    private Rigidbody2D rb;
    private bool isMovingRight = true;
    public bool isStopped = false;
    public bool moveDown = false;
    public bool moveUp = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        // check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space) && !isStopped)
        {
            isStopped = true;       
            rb.velocity = Vector2.zero; // stop movement
            moveDown = true;
        }
        if (moveDown)
        { 
           
            goDown();
        }

        if (moveUp || transform.position.y < bottom)
        {
            moveDown = false;
            goUp();
        }
        
        if (transform.position.y > top)
        {
            transform.position = new Vector2(transform.position.x, top - 0.1f);
            // start moving right and left again

            rb.velocity = Vector2.zero;

            isStopped = false;
            moveDown = false;
            moveUp = false;
            
        }

        //if (Input.GetKeyUp(KeyCode.Space)) {
        //    isStopped = false;
        //    //rb.velocity = Vector2.zero; // stop movement
        //    swingSpeed = 3.0f;

        //}


        if (!isStopped)
        {
            if (isMovingRight)
            {
                rb.velocity = new Vector2(moveSpeed, 0);
                if (transform.position.x >= maxX)
                {
                    Debug.Log("out of bound too far right");
                    isMovingRight = false;
                }

            }
            else if (!isMovingRight)
            {
                rb.velocity = new Vector2(-moveSpeed, 0);
                if (transform.position.x <= minX)
                {
                    Debug.Log("out of bound too far left");
                    isMovingRight = true;
                }
            }
        }

        //float direction = isMovingRight ? 1.0f : -1.0f;
        //rb.velocity = new Vector2(swingSpeed * direction, rb.velocity.y);
    }

    public void goDown() {
        rb.velocity = new Vector2(0, -hookSpeed);
    }

    public void goUp()
    { 
        rb.velocity = new Vector2(0, hookSpeed);
    }



}
