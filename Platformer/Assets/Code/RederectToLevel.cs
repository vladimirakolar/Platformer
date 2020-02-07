using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RederectToLevel : MonoBehaviour
{
    public static int rederecToLevel;
    public static int nextLevel;

    private void Update()
    {
        if (rederecToLevel == 3)
        {
            SceneManager.LoadScene(rederecToLevel);
        }
    }
}
