using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public int moralStatus; //1 = immoral, 2 = neutral, 3 = moral
    public Sprite[] newspaperSprites;
    public GameObject darkRoomManger;

    [Header("Mission 1")]
    bool[] soldierCheck;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void GetInfoFinal()
    {
        moralStatus = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral;
        newspaperSprites[0] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[0];
        newspaperSprites[0] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[1];

        CheckMissionComplete1();
    }
    public void CheckMissionComplete1()
    {
        //check each soldier is in photo, 
    }

}
