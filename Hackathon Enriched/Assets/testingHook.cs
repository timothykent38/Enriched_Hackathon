using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingHook : MonoBehaviour
{
    float speed = 10f;
    float hori;
    float vert;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(hori * speed, vert * speed);
    }
}
