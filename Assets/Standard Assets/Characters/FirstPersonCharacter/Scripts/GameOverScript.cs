using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI Score;
    public TextMeshProUGUI bestTimeText;
    public ScoreManager scoreManager;
    public VidPlayer vidPlayer;
    public void Setup(int score)
    {
        gameOverUI.GetComponent<CanvasGroup>().alpha = 1;
        timeText.text = $"Time: {scoreManager.FormatTime(scoreManager.GetCurrentTime())}";
        bestTimeText.text = $"Best Time: {scoreManager.FormatTime(scoreManager.GetBestTime())}";
    }
    IEnumerator VideoEnd ()
    {
        Debug.Log("Here");
        yield return new WaitForSeconds(4);
        EndReached();
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("01-Probuilder");
        timerText.gameObject.SetActive(true);
        Score.gameObject.SetActive(true);
    }

    public void SodaButton()
    {
        gameOverUI.GetComponent<CanvasGroup>().alpha = 0;
        vidPlayer.PlayVideo();
        StartCoroutine (VideoEnd());
        timerText.gameObject.SetActive(false);
        Score.gameObject.SetActive(false);
    }

    void EndReached()
    {
        gameOverUI.GetComponent<CanvasGroup>().alpha = 1;
        timerText.gameObject.SetActive(true);
        Score.gameObject.SetActive(true);
    }
}
