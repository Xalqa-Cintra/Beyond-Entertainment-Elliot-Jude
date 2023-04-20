using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoomPhotos : MonoBehaviour
{
    public GameObject cameraManager;
    public GameObject[] photoSelectables;
    public SpriteRenderer[] photoMeshSprite;
    int currentPhoto;
    public bool[] photoDone;

    private void Start()
    {
        currentPhoto = cameraManager.GetComponent<PhotoCapture>().photoTaken;


    }
    public void PhotoTaken()
    {
        currentPhoto++;
        
        photoSelectables[currentPhoto].SetActive(true);

        Sprite currentPhotoSprite = cameraManager.GetComponent<PhotoCapture>().photoSprite;
        
        photoMeshSprite[currentPhoto].sprite = currentPhotoSprite;
        photoDone[currentPhoto] = true;

        if(photoDone[0] == true)
        {

        }
    }

}
