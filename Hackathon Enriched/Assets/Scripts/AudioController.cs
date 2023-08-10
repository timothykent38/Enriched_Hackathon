using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public GameObject audItem;
    public AudioSource auderItem;
    public GameObject audBomb;
    public AudioSource auderBomb;
    // Start is called before the first frame update
    void Start()
    {
        audItem = GameObject.FindWithTag("Item_Sound");
        auderItem = audItem.GetComponent<AudioSource>();
        audBomb = GameObject.FindWithTag("Bomb_Sound");
        auderBomb = audBomb.GetComponent<AudioSource>();
        StartCoroutine(turnSoundOn());
    }
    IEnumerator turnSoundOn()
    {
        yield return new WaitForSeconds(1);
        auderBomb.volume = 1;
        auderItem.volume = 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
