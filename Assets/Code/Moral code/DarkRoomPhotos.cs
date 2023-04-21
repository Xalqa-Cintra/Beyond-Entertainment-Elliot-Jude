using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoomPhotos : MonoBehaviour
{
    public GameObject cameraManager;
    public GameObject[] photoSelectables;
    public SpriteRenderer[] photoMeshSprite;
    public Sprite[] spriteArray;
    int currentPhoto;

    private void Start()
    {
        currentPhoto = cameraManager.GetComponent<PhotoCapture>().photoTaken;


    }
    public void PhotoTaken()
    {
        
        
        photoSelectables[currentPhoto].SetActive(true);

        spriteArray[currentPhoto] = cameraManager.GetComponent<PhotoCapture>().photoSprite[currentPhoto];

        switch (currentPhoto)
        {
            case 0:
                photoMeshSprite[0].sprite = spriteArray[0];
                break;
            case 1:
                photoMeshSprite[1].sprite = spriteArray[1];
                break;
            case 2:
                photoMeshSprite[2].sprite = spriteArray[2];
                break;
            case 3:
                photoMeshSprite[3].sprite = spriteArray[3];
                break;
            case 4:
                photoMeshSprite[4].sprite = spriteArray[4];
                break;
            case 5:
                photoMeshSprite[5].sprite = spriteArray[5];
                break;
        }

        currentPhoto++;

    }

}
