using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject gameOverUI;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI bestTimeText;
    public ScoreManager scoreManager;
    public void Setup(int score)
    {
        gameOverUI.SetActive(true);
        videoPlayer.loopPointReached += EndReached;
        timeText.text = $"Time: {scoreManager.FormatTime(scoreManager.GetCurrentTime())}";
        bestTimeText.text = $"Best Time: {scoreManager.FormatTime(scoreManager.GetBestTime())}";
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("01-Probuilder");
        timerText.gameObject.SetActive(true);
        Score.gameObject.SetActive(true);
    }

    public void SodaButton()
    {
        gameOverUI.SetActive(false);
        videoPlayer.Play();
        timerText.gameObject.SetActive(false);
        Score.gameObject.SetActive(false);
    }

    void EndReached(VideoPlayer vp)
    {
        gameOverUI.SetActive(true);
        timerText.gameObject.SetActive(true);
        Score.gameObject.SetActive(true);
    }
}
