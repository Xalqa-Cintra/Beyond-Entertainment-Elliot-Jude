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

    [Header("Flash Effect")]
    [SerializeField] private GameObject cameraFlash;
    [SerializeField] private float flashTime;

    [Header("Photo Fader Effect")]
    [SerializeField] private Animator fadingAnimation;

    public GameObject camHud;
    public GameObject[] photoicons;
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
        Sprite photoSprite = Sprite.Create(screenCapture, new Rect(0.0f, 0.0f, screenCapture.width, screenCapture.height), new Vector2(0.5f, 0.5f), 100.0f);
        photoDislayArea.sprite = photoSprite;


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
        viewingPhoto = false;
        photoLimit --;
        photoTaken++;
        photoFrame.SetActive(false);
        

        // CameraUI true
    }

    void CheckLimit()
    {
        photoicons[photoTaken].SetActive(false);
    }

    public void SetMaxLimit()
    {
        photoicons[0].SetActive(false);
        photoicons[1].SetActive(false);
        photoicons[2].SetActive(false);
        photoicons[3].SetActive(false);
        photoicons[4].SetActive(false);
        photoicons[5].SetActive(false);
        switch (photoLimit)
        {
            case 1:
                photoicons[0].SetActive(true); break;
            case 2:
                photoicons[0].SetActive(true);
                photoicons[1].SetActive(true); break;
            case 3:
                photoicons[0].SetActive(true);
                photoicons[1].SetActive(true);
                photoicons[2].SetActive(true); break;
            case 4:
                photoicons[0].SetActive(true);
                photoicons[1].SetActive(true);
                photoicons[2].SetActive(true);
                photoicons[3].SetActive(true); break;
            case 5:
                photoicons[0].SetActive(true);
                photoicons[1].SetActive(true);
                photoicons[2].SetActive(true);
                photoicons[3].SetActive(true);
                photoicons[4].SetActive(true); break;
            case 6:
                photoicons[0].SetActive(true);
                photoicons[1].SetActive(true);
                photoicons[2].SetActive(true);
                photoicons[3].SetActive(true);
                photoicons[4].SetActive(true);
                photoicons[5].SetActive(true); break;
        }
    }

    //Gamobject[] store all shots
    //when take shot, disable 1 

    //create gameobject of picture
    //put moral value into it
    //place in darkroom
    //let player be able to pick it
    //add somewhere for the photos to be saved when taken 
}
