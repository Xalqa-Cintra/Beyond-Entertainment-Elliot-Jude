using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public int moralStatus; //1 = immoral, 2 = neutral, 3 = moral
    public Sprite[] newspaperSprites;
    public GameObject darkRoomManger, paperManager;

    int keywordsUsedStorage;

    [Header("Mission 1")]
    public bool missionSucceed1;
    [Header("Mission 2")]
    public bool missionSucceed2;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        darkRoomManger = GameObject.Find("DarkRoomManager");
        paperManager = GameObject.Find("PaperManager");
    }
    public void GetInfoFinal()
    {
        darkRoomManger.GetComponent<DarkRoomPhotos>().FinalCheck();
        moralStatus = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral;
        newspaperSprites[0] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[0].sprite;
        newspaperSprites[1] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[1].sprite;
        

        CheckMissionComplete1();
    }
    public void CheckMissionComplete1()
    {
        if(darkRoomManger.GetComponent<DarkRoomPhotos>().finalSoldiers==5)
        {
            missionSucceed1= true;
        }
        //check each soldier is in photo, 
    }
    public void GetNewsInfo()
    {
        keywordsUsedStorage = paperManager.GetComponent<PaperCode>().keywordUsed;
    }

}
