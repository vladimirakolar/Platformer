using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttomPress;

    public void PlayGame()
    {
        buttomPress.Play();
        RederectToLevel.rederecToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttomPress.Play();
        SceneManager.LoadScene(4);
    }
}
