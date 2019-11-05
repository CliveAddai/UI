using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void AudioPlayer()
    {
        SceneManager.LoadScene(2);
    }

    public void Pong()
    {
        SceneManager.LoadScene(3);
    }

    public void Snake()
    {
        SceneManager.LoadScene(4);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
