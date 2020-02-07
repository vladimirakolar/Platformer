using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimeRed : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 250;
        collectSound.Play();
        Destroy(gameObject);
    }
}
