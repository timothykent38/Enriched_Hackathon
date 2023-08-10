using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    int livesRemaining = 3;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // if lives remaining == 0 end game
        if (livesRemaining == 0)
        {
            endGame();
        }
    }

    public void loseLife() {
        livesRemaining--;
        transform.GetChild(livesRemaining).gameObject.SetActive(false);
    }

    void endGame()
    {
        Time.timeScale = 0;
        // set the game over text to be active
    }



}
