using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hookHitArea : MonoBehaviour
{
    GameObject hook;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        hook = GameObject.FindWithTag("Hook");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
        Vector2 move = new Vector2(hook.transform.position.x, hook.transform.position.y-offset);
 
        transform.position = move;
    }
}
