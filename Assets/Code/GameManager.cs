using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public int moralStatus; //1 = immoral, 2 = neutral, 3 = moral
    public Sprite[] newspaperSprites;
    public GameObject darkRoomManger, paperManager;
    int keywordsUsedStorage, Day;
    

    [Header("Mission 1")]
    public bool missionSucceed1;
    public int day1Value;
    [Header("Mission 2")]
    public bool missionSucceed2;
    public int day2Value;
    [Header("Mission 3")]
    public bool missionSucceed3;
    public int day3Value;

    private void Awake()
    {
            DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        darkRoomManger = GameObject.Find("DarkRoomManager");
        paperManager = GameObject.Find("PaperManager");

    }
    public void MoveScene()
    {
        paperManager = GameObject.Find("PaperManager");
    }
    public void GetInfoFinal()
    {
        darkRoomManger.GetComponent<DarkRoomPhotos>().FinalCheck();
        moralStatus = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral;
        newspaperSprites[0] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[0].sprite;
        newspaperSprites[1] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite[1].sprite;
        
        if(Day == 0) { CheckMissionComplete1(); day1Value = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral; }
        if (Day == 1) { CheckMissionComplete2(); day2Value = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral; }
        if (Day == 2) { CheckMissionComplete3(); day3Value = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral; }

    }
    public void CheckMissionComplete1()
    {
        if(darkRoomManger.GetComponent<DarkRoomPhotos>().finalSoldiers==5)
        {
            missionSucceed1= true;
        }
        //check each soldier is in photo, 
    }
    public void CheckMissionComplete2()
    {
        if (darkRoomManger.GetComponent<DarkRoomPhotos>().countedSarge == true)
        {
            missionSucceed2 = true;
        }
        //check each soldier is in photo, 
    }
    public void CheckMissionComplete3()
    {
        if (darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral == 3)
        {
            missionSucceed3 = true;
        }
        //check each soldier is in photo, 
    }
    public void GetNewsInfo()
    {
        keywordsUsedStorage = paperManager.GetComponent<PaperCode>().keywordUsed;
    }

}
