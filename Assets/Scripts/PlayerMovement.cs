using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;


    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 motion = transform.forward * z + transform.right * x;
        controller.Move(motion * speed * Time.deltaTime);
    }
}
