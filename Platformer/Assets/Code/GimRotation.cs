using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimRotation : MonoBehaviour
{
    public int rotateSpeed = 2;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

}
