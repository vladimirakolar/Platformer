﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttomPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST:" + bestScore;
    }

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

    public void ResetBest ()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
    }
}
