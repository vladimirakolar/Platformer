﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimeGreen : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 500;
        collectSound.Play();
        Destroy(gameObject);
    }
}
