using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerCameraMove : MonoBehaviour
{

    public float mousespeed = 5;

    private float camerarotation = 0;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float verticalmouse = Input.GetAxis("Mouse Y");

        camerarotation += verticalmouse * mousespeed * Time.deltaTime;
        camerarotation = Mathf.Clamp(camerarotation, -50f, 30f);
        transform.localRotation = Quaternion.AngleAxis(camerarotation, Vector3.left);


        
    }
}

