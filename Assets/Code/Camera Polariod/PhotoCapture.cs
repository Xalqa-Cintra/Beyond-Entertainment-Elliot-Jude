using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class PhotoCapture : MonoBehaviour
{
    [Header("Photo Taker")]
    [SerializeField] private Image photoDislayArea;
    [SerializeField] private GameObject photoFrame;
    public Sprite[] photoSprite;

    [Header("Flash Effect")]
    [SerializeField] private GameObject cameraFlash;
    [SerializeField] private float flashTime;

    [Header("Photo Fader Effect")]
    [SerializeField] private Animator fadingAnimation;

    public GameObject camHud, darkRoomManager;
    public GameObject[] photoIcons;
    private Texture2D screenCapture;
    public bool viewingPhoto;
    public bool canTakePhoto, photoRemoved, inCamera;
    
    
    
    public int photoLimit, photoTaken;
    private void Start()
    {
        SetMaxLimit();
       
        screenCapture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        camHud.SetActive(false);
    }

    private void Update()
    {
        if(canTakePhoto)
        {
            

            camHud.SetActive(true);
        }
        else
        {
            camHud.SetActive(false);
        }

            

            if (Input.GetMouseButtonDown(0) && canTakePhoto && photoLimit > 0)
            {
                if (!viewingPhoto)
                {
                    StartCoroutine(CapturePhoto());
                    photoRemoved = false;

                }
                else
                {
                    CheckLimit();
                    RemovePhoto();
                    photoRemoved = true;
                    
                }

            }
        

    }

    IEnumerator CapturePhoto()
    {
        // Camera UI set False
        viewingPhoto = true;
        camHud.SetActive(false);
        yield return new WaitForEndOfFrame();

        Rect regionToRead = new Rect(0, 0, Screen.width, Screen.height);

        screenCapture.ReadPixels(regionToRead, 0, 0, false);
        screenCapture.Apply();
        ShowPhoto();
    }

    void ShowPhoto()
    {
        photoSprite[photoTaken] = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        photoDislayArea.sprite = photoSprite[photoTaken];


        photoFrame.SetActive(true);
        StartCoroutine(CameraFlashEffect());
        fadingAnimation.Play("PhotoFade");
    }

    IEnumerator CameraFlashEffect()
    {
        cameraFlash.SetActive(true);
        yield return new WaitForSeconds(flashTime);
        cameraFlash.SetActive(false);
    }




    void RemovePhoto()
    {
        darkRoomManager.GetComponent<DarkRoomPhotos>().PhotoTaken();
        viewingPhoto = false;
        photoLimit --;
        photoTaken++;
        photoFrame.SetActive(false);
    }

    void CheckLimit()
    {
        photoIcons[photoTaken].SetActive(false);
    }

    public void SetMaxLimit()
    {
        photoIcons[0].SetActive(false);
        photoIcons[1].SetActive(false);
        photoIcons[2].SetActive(false);
        photoIcons[3].SetActive(false);
        photoIcons[4].SetActive(false);
        photoIcons[5].SetActive(false);
        
        for (int i = 0; i < photoLimit; i++)
        {
            photoIcons[i].SetActive(true);
        }
    }

    //Gamobject[] store all shots
    //when take shot, disable 1 

    //create gameobject of picture
    //put moral value into it
    //place in darkroom
    //let player be able to pick it
    //add somewhere for the photos to be saved when taken 

//PUT PHOTO ONTO REDROOM
    // cube in redroom
    // setactive(false)
    // set up a foreach meshfilter, add to array
    //when photo taken, activate cube(phototaken)
    //pull and apply sprite in photo to the cube
    //setbool (photoXdone)
    //when bool active, dont repeat  

}
