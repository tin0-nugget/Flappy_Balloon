using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Functions : MonoBehaviour
{
    public void ChangeToPlayScene()
    {
        SceneManager.LoadScene("Game_Play_Scene");
    }

    public void ChangeToStartScreen()
    {
        SceneManager.LoadScene("Starting_Page");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
