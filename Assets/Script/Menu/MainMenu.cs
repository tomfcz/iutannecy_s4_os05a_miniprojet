using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Scene Robin");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Scene Robin");
    }

    public void QuitButton()
    {
        if (EditorUtility.DisplayDialog("Quit the game ?",
            "Are you sure you want to quit the game ?\n" +
            "Your progression will not be saved.",
            "Yes", "No"))
        {
            Application.Quit();
        }
    }
}
