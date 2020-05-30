using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float sensitivity;
    public Transform body;

    private float rotateX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        
        rotateX -= mouseY;
        rotateX = Mathf.Clamp(rotateX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(rotateX, 0f, 0f);
        body.Rotate(Vector3.up * mouseX);
    }
}
