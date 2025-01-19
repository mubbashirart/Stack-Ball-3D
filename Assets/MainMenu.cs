using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Method to start the game
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); // Load the scene with build index 1
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void ExitGame()
    {
        Application.Quit();   
    }
}
