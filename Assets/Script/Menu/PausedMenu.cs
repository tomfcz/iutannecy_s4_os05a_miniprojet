using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    [SerializeField] GameObject pausedMenu;
    public static bool isPaused;
    public GameObject pauseButton;

    public void start()
    {
        pausedMenu.SetActive(true);
        pauseButton.SetActive(true);
    }

    public void PauseGame()
    {
        pausedMenu.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausedMenu.SetActive(false);
        pauseButton.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void GoToMainMenu()
    {
        if(EditorUtility.DisplayDialog("Return to the main menu ?",
            "Are you sure you want to return to the main menu ?\n" +
            "Your progression will not be saved.",
            "Yes", "No"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Main menu");
            isPaused = false;
        }
        
    }

    public void Quit()
    {
        if (EditorUtility.DisplayDialog("Quit the game ?",
            "Are you sure you want to quit the game ?\n" +
            "Your progression will not be saved.",
            "Yes", "No"))
        {
            Application.Quit();
        }
    }

    public void test()
    {
        Debug.Log("test oui");
    }
    
}


/*
 [SerializeField] GameObject pausedMenu;

    public void PauseGame()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        pausedMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene Robin");
    }

    public void Quit()
    {
        Application.Quit();
    } 
 
 
 */
