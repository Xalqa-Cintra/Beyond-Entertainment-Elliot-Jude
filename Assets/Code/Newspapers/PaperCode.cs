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
    public Text requirementsText, paperHeader;
    public string[] keywords, headerWords, wantedKeywords;
    bool toggle, toggle1, canGoNextDay;
    public string input;
    public int currentWord, keywordUsed;
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager");
        newspaperImgs[0] = gameManager.GetComponent<GameManager>().newspaperSprites[0];
        newspaperImgs[1] = gameManager.GetComponent<GameManager>().newspaperSprites[1];
        imgLocations[0].texture = newspaperImgs[0].texture;
        imgLocations[1].texture = newspaperImgs[1].texture;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (gameManager.GetComponent<GameManager>().moralStatus == 3)
        {
           requirementsText.text = "We want the keywords: " + keywords[0] + "," + keywords[1] + "," + keywords[2];
            wantedKeywords[0] = keywords[0];
            wantedKeywords[1] = keywords[1];
            wantedKeywords[2] = keywords[2];
        }
        if(gameManager.GetComponent<GameManager>().moralStatus == 2)
        {
           requirementsText.text = "We want the keywords: " + keywords[3] + "," + keywords[4] + "," + keywords[5];
            wantedKeywords[0] = keywords[3];
            wantedKeywords[1] = keywords[4];
            wantedKeywords[2] = keywords[5];
        }
        if(gameManager.GetComponent<GameManager>().moralStatus == 1)
        {
           requirementsText.text = "We want the keywords: " + keywords[6] + "," + keywords[7] + "," + keywords[8];
            wantedKeywords[0] = keywords[6];
            wantedKeywords[1] = keywords[7];
            wantedKeywords[2] = keywords[8];
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(input == (wantedKeywords[0]))
            {
                keywordUsed++;
            }
            else if (input == (wantedKeywords[1]))
            {
                keywordUsed++;
            }
            else if (input == (wantedKeywords[2]))
            {
                keywordUsed++;
            }
            currentWord++;
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
        if (keywordUsed == 0) { canGoNextDay = false; } else { canGoNextDay = true; }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReadStringInput(string s)
    {
        input = s;
        paperHeader.text = s;

    }


    // check moral status in gamemanager x
    // pull sprites and put onto 2 renderers x
    // have optional areas for photos
    // maybe players can set text themselves, will require me to have an ai or sumin painful to check for keywords
    // 

}
