using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform player;

    Camera cam;    

    public float HeightView => cam.orthographicSize;

    void Start()
    {
        cam = GetComponent<Camera>();
        float screenW = Screen.width;
        float screenH = Screen.height;

        float newW = cam.rect.height * screenH / screenW;
        float newX = cam.rect.x + cam.rect.height - newW;

        cam.rect = new Rect(newX, cam.rect.y, newW, cam.rect.height);
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
