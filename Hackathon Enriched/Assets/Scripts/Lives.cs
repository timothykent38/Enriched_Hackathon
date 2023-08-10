using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    int livesRemaining = 3;
    UI_Manager ui;
    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.FindWithTag("UI").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        // if lives remaining == 0 end game
        if (livesRemaining == 0)
        {
            ui.gameOver();
        }
    }

    public void loseLife() {
        livesRemaining--;
        transform.GetChild(livesRemaining).gameObject.SetActive(false);
    }

    



}
