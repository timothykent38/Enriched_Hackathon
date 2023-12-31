using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaItem : MonoBehaviour
{
    public bool hitByHook;
    public GameObject hook;
    public UI_Manager ui;
    public GameObject hookArea;
    public MoveHook mh;
    public int score;
    public GameObject aud;
    public AudioSource auder;
    // Start is called befor
    //e the first frame update
    void Start()
    {
        hitByHook = false;
        hook = GameObject.FindWithTag("Hook");
        hookArea = GameObject.FindWithTag("Hook_Area");
        mh = hook.GetComponent<MoveHook>();
        ui = GameObject.FindWithTag("UI").GetComponent<UI_Manager>();
        aud = GameObject.FindWithTag("Item_Sound");
        auder = aud.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (hitByHook)
        {
            //  Debug.Log(hook);
            Vector2 move = new Vector2(hook.transform.position.x, hook.transform.position.y);
            transform.position = hookArea.transform.position;
            if (transform.position.y > 6.5f)
            {
                GameObject.Destroy(this.gameObject);
                // add to the score
                addScore(score);
            }

        }
    }

    void addScore (int score) {
        ui.addScore(score);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hook");
        if (other.gameObject.tag == "Hook")
        {
            hitByHook = true;
            mh.moveUp = true;
            auder.Play();
        }
    }
}
