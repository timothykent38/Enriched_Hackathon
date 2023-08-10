using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        scoreText.text = "Hello";
        addScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore (int toAdd)
    {
        Debug.Log("text is chaning");
        score += toAdd;
        scoreText.text = "Score: " + score;
    }
}
