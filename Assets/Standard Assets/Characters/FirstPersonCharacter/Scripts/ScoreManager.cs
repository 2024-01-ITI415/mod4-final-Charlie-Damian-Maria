using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public int score;
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Soda: " + score + "/16";
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Soda: " + score + "/16";
        if (score >= 16)
        {
            gameController.GameOver();
        }
    }

}
