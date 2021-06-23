using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationRandomizer : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 0.55f;
    public float angle = 90f;
    public float inTime = 2f;
 

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RotateObject(Vector3.up));
       
    }

    IEnumerator RotateObject(Vector3 axis)
    {
        float rotationSpeed = angle / inTime;
        while (true)
        {
            Quaternion startRotation = transform.rotation;
            float deltaAngle = 0;
            while (deltaAngle < angle)
            {
                deltaAngle += rotationSpeed * Time.deltaTime;
                deltaAngle = Mathf.Min(deltaAngle, angle);
                transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);

                yield return null;
            }

            yield return new WaitForSeconds(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * Vector3.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.name == "BoundariesPlane") {
            transform.position -= transform.position;
        }
        
    }
}
