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
    public GameObject boom;
    public GameObject aud;
    public AudioSource auder;
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
        aud = GameObject.FindWithTag("Bomb_Sound");
        auder = aud.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator boomAnimation(Transform t) {
        gameObject.GetComponent<Renderer>().enabled = false;
        GameObject b = Instantiate(boom, t.position, t.rotation);
        yield return new WaitForSeconds(1);
        Debug.Log("Destory");
        GameObject.Destroy(b.gameObject);
       
        GameObject.Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hook")
        {
            mh.moveUp = true;
            auder.Play();
           
            lives.loseLife();

            Transform t = transform;
            
            
            
            StartCoroutine(boomAnimation(t));  
        }
    }
}
