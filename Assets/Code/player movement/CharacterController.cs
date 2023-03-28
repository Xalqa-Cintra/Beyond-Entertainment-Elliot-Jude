using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed = 12.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    float xRotation;
    float sensY;
    public GameObject cam;
    Rigidbody rb;

    float rotationSpeed = 2.0f;
    float camRoatationSpeed = 1.5f;

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    { float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        xRotation += mouseY;

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
        rb.velocity = new Vector3(newVelocity.x, rb.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRoatationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));

        camRotation = Mathf.Clamp(camRotation, -45f, 45f);
        
    }
}