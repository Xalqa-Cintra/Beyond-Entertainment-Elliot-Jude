using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float maxSpeed;
    float normalSpeed = 10.0f;
    float sprintSpeed = 14.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    float xRotation;
    float sensY;
    public GameObject cam;
    Rigidbody rb;
    public GameObject cameraManager, gameManager;
    float rotationSpeed = 2.0f;
    float camRoatationSpeed = -1.5f;
    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groudLayer;
    public float jumpForce = 300.0f;
    public float maxSprint = 5.0f, gravity;
    float sprintTimer;
    public int added;

    public Transform darkroomTP, bunkerTP, mapTP, bunkerMapTP, warTP, warMapTP;


    void Start()
    {
        sprintTimer = maxSprint;
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groudLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        rb.AddForce(transform.up * (gravity * -1), ForceMode.Force);

        if (Input.GetKey(KeyCode.LeftShift) && sprintTimer > 0.0f)
        {
            maxSpeed = sprintSpeed;
            sprintTimer = sprintTimer - Time.deltaTime;
        }
        else
        {
            maxSpeed = normalSpeed;
            if(Input.GetKey(KeyCode.LeftShift) == false && sprintTimer < maxSprint)
            {
                sprintTimer = sprintTimer + Time.deltaTime;
            }
        }

        sprintTimer = Mathf.Clamp(sprintTimer, 0.0f, maxSprint);

        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        xRotation += mouseY;

        Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxSpeed) + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);
        rb.velocity = new Vector3(newVelocity.x, rb.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRoatationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));

        camRotation = Mathf.Clamp(camRotation, -30f, 30f);

        if (Input.GetMouseButtonDown(1))
        {
            cameraManager.GetComponent<PhotoCapture>().canTakePhoto = !cameraManager.GetComponent<PhotoCapture>().canTakePhoto;

        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Camera Pickup")
        {
            cameraManager.GetComponent<PhotoCapture>().photoLimit += added;
            cameraManager.GetComponent<PhotoCapture>().SetMaxLimit();
            cameraManager.GetComponent<PhotoCapture>().photoTaken = 0;
            Destroy(other.gameObject);
        }
        if (other.tag == "DarkroomTP")
        {
            transform.position = darkroomTP.position;
        }
        if (other.tag == "BunkerTP")
        {
            transform.position = bunkerTP.position;
        }
        if (other.tag == "MapTP")
        {
            cameraManager.GetComponent<PhotoCapture>().photoLimit = 3;
            cameraManager.GetComponent<PhotoCapture>().SetMaxLimit();
            transform.position = mapTP.position;
        }
        if (other.tag == "BunkerMapTP")
        {
            transform.position = bunkerMapTP.position;
        }
        if (other.tag == "WarTP")
        {
            transform.position = warTP.position;
        }
        if (other.tag == "WarMapTP")
        {
            transform.position = warMapTP.position;
        }
    }
}
