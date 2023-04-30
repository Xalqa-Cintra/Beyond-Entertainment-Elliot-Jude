using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperCode : MonoBehaviour
{

    public GameObject gameManager;
    public Sprite[] newspaperImgs;
    public RawImage[] imgLocations;
    public RawImage[] finalLocation;
    public Text keywords;
    public string[] keywordList;
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        newspaperImgs[0] = gameManager.GetComponent<GameManager>().newspaperSprites[0];
        newspaperImgs[1] = gameManager.GetComponent<GameManager>().newspaperSprites[1];
        imgLocations[0].texture = newspaperImgs[0].texture;
        imgLocations[1].texture = newspaperImgs[1].texture;

        if (gameManager.GetComponent<GameManager>().moralStatus == 1)
        {
           keywords.text = "We want the keywords: " + keywordList[0];
        }
        if(gameManager.GetComponent<GameManager>().moralStatus == 2)
        {
           keywords.text = "We want the keywords: " + keywordList[1];
        }
        if(gameManager.GetComponent<GameManager>().moralStatus == 3)
        {
           keywords.text = "We want the keywords: " + keywordList[2];
        }
    }
    // check moral status in gamemanager x
    // pull sprites and put onto 2 renderers x
    // have optional areas for photos
    // maybe players can set text themselves, will require me to have an ai or sumin painful to check for keywords
    // 








}
