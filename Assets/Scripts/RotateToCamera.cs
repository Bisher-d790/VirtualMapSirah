using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        RotateToFaceCamera();
    }

    void RotateToFaceCamera()
    {
        transform.rotation = Quaternion.LookRotation(Camera.main.transform.forward, Camera.main.transform.up);
    }
}
