using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    // set float for sensitivity of the camera for the player
    public float sensX;
    public float sensY;

    // a transform for the player's orientation
    public Transform orientation;

    // set float for roation of the camera
    float xRotation;
    float yRotation;

    private void Start()
    {
        // lock the cursor and lock the state of it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        // unity trying to handle roations in the mouse
        yRotation += mouseX;
        xRotation -= mouseY;

        // stop roation 90 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // rotate cam and orientation 
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }


}
