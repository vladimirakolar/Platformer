using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RederectToLevel : MonoBehaviour
{
    public static int rederecToLevel = 1;


    private void Update()
    {
        if (rederecToLevel == 1)
        {
            SceneManager.LoadScene(rederecToLevel);
        }
    }
}
