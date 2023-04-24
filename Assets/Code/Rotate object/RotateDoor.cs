using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDoor : MonoBehaviour
{
    public GameObject darkroomManager;
    public Transform rotatePoint;

    public float rotateTime;
    public float rotateAmount;

    private void Update()
    {
        if (rotateTime > 0)
        {
            if (darkroomManager.GetComponent<DarkRoomPhotos>().currentPhoto > 2)
            {
                DoorRotate();
            }
        }
    }

    private void DoorRotate()
    {
        transform.RotateAround(rotatePoint.position, Vector3.up, rotateAmount);
        rotateTime =- Time.deltaTime;
    }

}
