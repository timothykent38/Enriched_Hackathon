using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class CountDown : MonoBehaviour
{
    public int startingTime = 5;
    float timePassed = 0;
    public TextMeshProUGUI timerText;
    public UI_Manager ui;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        ui = GameObject.FindWithTag("UI").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;
        double curTime =  Math.Round(startingTime - timePassed,2);
        timerText.text = "" + curTime;
        if (curTime <= 0)
        {
            ui.gameOver();
        }
    }
}
