using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI timerText;
    public int score;
    public GameController gameController;
    private float elapsedTime = 0f;
    private bool isGameActive = true;
    private float bestTime = float.MaxValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Soda: " + score + "/16";
        timerText.text = FormatTime(0);
    }
    void Update()
    {
        if (isGameActive)
        {
            elapsedTime += Time.deltaTime;
            timerText.text = FormatTime(elapsedTime);
        }
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Soda: " + score + "/16";
        if (score >= 16)
        {
            isGameActive = false;
            if (elapsedTime < bestTime)
            {
                bestTime = elapsedTime;
            }
            gameController.GameOver();
        }
    }
    public float GetCurrentTime()
    {
        return elapsedTime;
    }

    public float GetBestTime()
    {
        return bestTime;
    }
    public string FormatTime(float timeToFormat)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeToFormat);
        return timeSpan.ToString("mm':'ss'.'ff");  // Format as minutes:seconds.fractions
    }
    }
