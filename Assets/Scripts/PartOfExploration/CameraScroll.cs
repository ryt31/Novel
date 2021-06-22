using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float Speed;
    public float EndPosition;

    [SerializeField] private Transform playerPos;
    private Camera camera;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if (transform.position.x < EndPosition && camera.ScreenToWorldPoint(Vector3.zero).x < playerPos.position.x)
        {
            transform.Translate(new Vector3(Speed, 0, 0) * Time.deltaTime);
        }
    }
}
