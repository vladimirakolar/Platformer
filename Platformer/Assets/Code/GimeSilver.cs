﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GimeSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        scoreBox.GetComponent<Text>().text = "1000";
        collectSound.Play();
        Destroy(gameObject);
    }
}
