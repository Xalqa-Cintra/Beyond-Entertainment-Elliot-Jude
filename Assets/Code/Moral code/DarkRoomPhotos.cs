using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoomPhotos : MonoBehaviour
{
    public GameObject cameraManager;
    public GameObject[] photoSelectables;
    public SpriteRenderer[] photoMeshSprite;
    public int currentPhoto;

    private void Start()
    {
        currentPhoto = cameraManager.GetComponent<PhotoCapture>().photoTaken;


    }
    public void PhotoTaken()
    {
        

        photoSelectables[currentPhoto].SetActive(true);

        switch (currentPhoto)
        {
            case 0:
                photoMeshSprite[0].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[0].GetComponent<PhotosInfo>().FindInfo();
                break;
            case 1:
                photoMeshSprite[1].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[1].GetComponent<PhotosInfo>().FindInfo();
                break;
            case 2:
                photoMeshSprite[2].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[2].GetComponent<PhotosInfo>().FindInfo();
                break;
            case 3:
                photoMeshSprite[3].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[3].GetComponent<PhotosInfo>().FindInfo();
                break;
            case 4:
                photoMeshSprite[4].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[4].GetComponent<PhotosInfo>().FindInfo();
                break;
            case 5:
                photoMeshSprite[5].sprite = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];
                photoSelectables[5].GetComponent<PhotosInfo>().FindInfo();
                break;
        }

        currentPhoto++;

    }

}
