using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("stop", false);
        anim.SetBool("up", false);
        anim.SetBool("down", false);
        anim.speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            goUp();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            stop();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            goDown();
        }
    }

    public void stop()
    {
        anim.SetBool("up", false);
        anim.SetBool("down", false);
    }

    public void goUp()
    {

        anim.SetBool("up", true);
        anim.SetBool("down", false);
    }

    public void goDown()
    {
        anim.SetBool("up", false);
        anim.SetBool("down", true);
    }

}
