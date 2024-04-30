using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class GameOverScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject gameOverUI;
    public void Setup(int score)
    {
        gameOverUI.SetActive(true);
        videoPlayer.loopPointReached += EndReached;
    }
    public void RestartButton()
    {
        Debug.Log("Restart button clicked.");
        SceneManager.LoadScene("01-Probuilder");
    }

    public void SodaButton()
    {
        gameOverUI.SetActive(false);
        videoPlayer.Play();
    }

    void EndReached(VideoPlayer vp)
    {
        gameOverUI.SetActive(true);
    }
}
