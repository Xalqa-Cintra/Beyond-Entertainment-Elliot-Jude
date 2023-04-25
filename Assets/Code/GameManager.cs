using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int moralStatus; //1 = immoral, 2 = neutral, 3 = moral
    public Sprite[] newspaperSprites;
    public GameObject darkRoomManger;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void GetInfoFinal()
    {
        moralStatus = darkRoomManger.GetComponent<DarkRoomPhotos>().finalMoral;
        newspaperSprites[0] = darkRoomManger.GetComponent<DarkRoomPhotos>().finalSprite;
    }
    

}
