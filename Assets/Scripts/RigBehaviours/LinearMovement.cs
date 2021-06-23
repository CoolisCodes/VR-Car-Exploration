using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 100;
    public Transform mainCamera;
    public float playerHeight = 1.70f;

    private void Awake()
    {
        mainCamera = transform.GetChild(0);
    }

    void Update()
    {
        transform.position += mainCamera.rotation * Vector3.forward * speed;
        transform.position = new Vector3(transform.position.x, playerHeight, transform.position.z);
    }

}
