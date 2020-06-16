using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapTarget : MonoBehaviour
{
    public Transform target;
    public float scalePerUnitHeight;
    public Minimap minimap;

    void Start()
    {
        minimap = FindObjectOfType<Minimap>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            transform.position = target.position + Vector3.up * 10;
            transform.localScale = Vector3.one * scalePerUnitHeight * minimap.HeightView;
        }
    }
}
