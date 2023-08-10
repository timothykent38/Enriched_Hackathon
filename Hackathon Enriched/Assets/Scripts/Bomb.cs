using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    Lives lives;
    public bool hitByHook;
    public GameObject hook;
    public UI_Manager ui;
    public GameObject hookArea;
    public MoveHook mh;

    // Start is called before the first frame update

    // Start is called before the first frame update
    void Start()
    {
        lives = GameObject.FindWithTag("Lives").GetComponent<Lives>();
        hook = GameObject.FindWithTag("Hook");
        hookArea = GameObject.FindWithTag("Hook_Area");
        mh = hook.GetComponent<MoveHook>();
        ui = GameObject.FindWithTag("UI").GetComponent<UI_Manager>();

        mh = hook.GetComponent<MoveHook>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hook")
        {
            mh.moveUp = true;
            Debug.Log(mh.moveUp);
            lives.loseLife();
            GameObject.Destroy(this.gameObject);
            
        }
    }
}
