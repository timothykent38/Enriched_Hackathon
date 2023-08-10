using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public float beforeHit;
    public bool hitTrash;
    bool initpos = false;
    // Start is called before the first frame update
    void Start()
    {
        hitTrash = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (hitTrash) {
            if (!initpos)
            {
                beforeHit = transform.position.x;
                initpos = true;
            }

        }

        initpos = false;

    }
}
