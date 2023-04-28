using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkRoomPhotos : MonoBehaviour
{
    public GameObject cameraManager;
    public GameObject[] photoSelectables;
    public GameObject[] selectedPhoto;
    public SpriteRenderer[] photoMeshSprite;
    public int currentPhoto, finalMoral;
    public SpriteRenderer[] finalSprite;
    public int selectedAmt;
    public int finalSoldiers;
    public bool[] countedSoldiers;

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

    public void FinalCheck()
    {

        finalSprite[0] = selectedPhoto[0].GetComponent<SpriteRenderer>();
        finalSprite[1] = selectedPhoto[1].GetComponent<SpriteRenderer>();

        if (selectedPhoto[0].GetComponent<PhotosInfo>().photoValue < -3)
        {
            finalMoral = 1;
        }
        if (selectedPhoto[0].GetComponent<PhotosInfo>().photoValue > -3 && selectedPhoto[0].GetComponent<PhotosInfo>().photoValue < 5)
        {
            finalMoral = 2;
        }
        if (selectedPhoto[0].GetComponent<PhotosInfo>().photoValue > 5)
        {
            finalMoral = 3;
        }

        finalSprite[0] = selectedPhoto[1].GetComponent<SpriteRenderer>();
        finalSprite[1] = selectedPhoto[1].GetComponent<SpriteRenderer>();

        if (selectedPhoto[1].GetComponent<PhotosInfo>().photoValue < -3)
        {
            finalMoral = 1;
        }
        if (selectedPhoto[1].GetComponent<PhotosInfo>().photoValue > -3 && selectedPhoto[1].GetComponent<PhotosInfo>().photoValue < 5)
        {
            finalMoral = 2;
        }
        if (selectedPhoto[1].GetComponent<PhotosInfo>().photoValue > 5)
        {
            finalMoral = 3;
        }
        for (int i = 0; i < 5; i++)
        {
            if (selectedPhoto[0].GetComponent<PhotosInfo>().soldierSeen[i] == true && countedSoldiers[i] == false) {finalSoldiers++; countedSoldiers[i] = true;}
            if (selectedPhoto[1].GetComponent<PhotosInfo>().soldierSeen[i] == true && countedSoldiers[i] == false) { finalSoldiers++; countedSoldiers[i] = true; }
        }
    }


}
