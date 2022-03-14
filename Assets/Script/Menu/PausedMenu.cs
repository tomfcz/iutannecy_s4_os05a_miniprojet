using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    [SerializeField] GameObject pausedMenu;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        pausedMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pausedMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pausedMenu.SetActive(false);
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
            SceneManager.LoadScene("Scene Robin");
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
