using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemode : MonoBehaviour
{
    public void SinglePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //loads single player
    }

    public void OnlinePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);   //loads multiplayer
    }
}