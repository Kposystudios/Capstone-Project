using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //loads level 0
    }
    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);   //in theory should move back by one scene
    }
    public void SettingsButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);   //on click set active scene to 4 (settings menu)
       
    }
    public void SettingsBackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);   //on click set active scene to 4 (settings menu)

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
