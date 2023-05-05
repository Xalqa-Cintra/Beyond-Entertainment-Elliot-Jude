using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GaneEndCode : MonoBehaviour
{
    GameObject gameManager;
    public Text[] missions;
    public Text[] score;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("gamemanager");
        if (gameManager.GetComponent<GameManager>().missionSucceed1) { missions[0].text = "QUOTA MET"; } else { missions[0].text = "QUOTA FAILED"; }
        if (gameManager.GetComponent<GameManager>().missionSucceed2) { missions[1].text = "QUOTA MET"; } else { missions[1].text = "QUOTA FAILED"; }
        if (gameManager.GetComponent<GameManager>().missionSucceed3) { missions[2].text = "QUOTA MET"; } else { missions[2].text = "QUOTA FAILED"; }


    }
}
