using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public bool hitByHook;
    public GameObject hook;
    // Start is called before the first frame update
    void Start()
    {
        hitByHook = false;
        hook = GameObject.FindWithTag("Hook");
    }

    // Update is called once per frame
    void Update()
    {
        if (hitByHook)
        {
            transform.position = hook.transform.GetChild(0).transform.position;
            if (transform.position.y > 4) {
                GameObject.Destroy(this.gameObject);

            }

        }
    }

     void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("hook");
        if (other.gameObject.tag == "Hook") {
            hitByHook = true;
            hook.GetComponent<Hook>().hitTrash = true;
        }
    }
}
