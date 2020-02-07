﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RederectToLevel.rederecToLevel = 5;
        RederectToLevel.nextLevel = 6;
        StartCoroutine(FadeInOff());
    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);

    }
}
