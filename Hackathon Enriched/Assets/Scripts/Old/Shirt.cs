using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shirt : MonoBehaviour
{
    public bool hitByHook;
    public GameObject hook;
    public UI_Manager ui;
    public GameObject hookArea;
    public MoveHook mh;

    // Start is called before the first frame update
    void Start()
    {
        hitByHook = false;
        hook = GameObject.FindWithTag("Hook");
        hookArea = GameObject.FindWithTag("Hook_Area");
        mh = hook.GetComponent<MoveHook>();
        ui = GameObject.FindWithTag("UI").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hitByHook)
        {
            //  Debug.Log(hook);
            Vector2 move = new Vector2(hook.transform.position.x, hook.transform.position.y);
            transform.position = hookArea.transform.position;
            if (transform.position.y > 4)
            {
                GameObject.Destroy(this.gameObject);
                // add to the score
                ui.addScore(10);
            }

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hook");
        if (other.gameObject.tag == "Hook")
        {
            hitByHook = true;
            mh.moveUp = true;
        }
    }
}
