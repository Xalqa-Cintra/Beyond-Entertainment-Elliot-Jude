using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    public GameObject cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Camera Pickup")
        {
            cameraManager.GetComponent<PhotoCapture>().photoLimit += 2;
        }
        Destroy(other.gameObject);
    }
}
