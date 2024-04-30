using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour
{
    public GameOverScript GameOverScript;
    public ScoreManager ScoreManager;
    public FirstPersonController FirstPersonController;
    public void GameOver ()
    {
        GameOverScript.Setup(ScoreManager.score);
        if (FirstPersonController != null)
        {
            FirstPersonController.EnableCursor();
            FirstPersonController.enabled = false;
        }
    }

}
