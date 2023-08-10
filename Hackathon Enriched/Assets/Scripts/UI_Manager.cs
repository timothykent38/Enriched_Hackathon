using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI infoText;
    public GameObject hook;
    public int score = 0;
    bool infoNotPLayed = true;

    // Start is called before the first frame update
    void Start()
    {
        hook = GameObject.FindWithTag("Hook");
        addScore(0);

    }
    IEnumerator playInfo()
    {
        infoNotPLayed = false;
        infoText.GetComponent<CanvasGroup>().alpha = 1;
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(5);
        infoText.text = "Speeding up";
        infoText.color = Color.red;
        yield return new WaitForSecondsRealtime(2);
        Time.timeScale = 1;
        infoText.GetComponent<CanvasGroup>().alpha = 0;

        
    }
    // Update is called once per frame
    void Update()
    {
      if (score >= 75 && infoNotPLayed)
        {
            // play the info text
            StartCoroutine(playInfo());
            // double speed of hook
            hook.GetComponent<MoveHook>().hookSpeed *= 2;
            hook.GetComponent<MoveHook>().moveSpeed *= 2;
        }
    }

    public void addScore(int toAdd)
    {
       
        score += toAdd;
        scoreText.text = "Score: " + score;
    }

    public void gameOver()
    {
        gameOverText.GetComponent<CanvasGroup>().alpha = 1;
        Time.timeScale = 0;

    }

   

 }
