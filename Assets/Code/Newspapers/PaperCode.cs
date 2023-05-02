using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PaperCode : MonoBehaviour
{

    public GameObject gameManager;
    public GameObject[] buttonChildren;
    public Sprite[] newspaperImgs;
    public RawImage[] imgLocations;
    public RawImage[] finalLocation;
    public Text keywords;
    public string[] keywordList;
    bool toggle, toggle1;
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        newspaperImgs[0] = gameManager.GetComponent<GameManager>().newspaperSprites[0];
        newspaperImgs[1] = gameManager.GetComponent<GameManager>().newspaperSprites[1];
        imgLocations[0].texture = newspaperImgs[0].texture;
        imgLocations[1].texture = newspaperImgs[1].texture;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

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

    public void TRButton()
    {
        buttonChildren[0].SetActive(toggle);
        buttonChildren[1].SetActive(toggle);
        toggle= !toggle;
    }
    public void BRButton()
    {
        buttonChildren[2].SetActive(toggle1);
        buttonChildren[3].SetActive(toggle1);
        toggle1= !toggle1;
    }
    public void TRButton1()
    {
        finalLocation[0].texture = imgLocations[0].texture;

    }
    public void TRButton2()
    {
        finalLocation[0].texture = imgLocations[1].texture;
    }
    public void BRButton1()
    {
        finalLocation[1].texture = imgLocations[0].texture;
    }
    public void BRButton2()
    {
        finalLocation[1].texture = imgLocations[1].texture;
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // check moral status in gamemanager x
    // pull sprites and put onto 2 renderers x
    // have optional areas for photos
    // maybe players can set text themselves, will require me to have an ai or sumin painful to check for keywords
    // 

}
