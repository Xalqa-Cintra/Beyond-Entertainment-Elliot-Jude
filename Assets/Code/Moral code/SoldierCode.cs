using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCode : MonoBehaviour
{

    public GameObject cameraManager;

    public GameObject[] allsoldiers;

    public bool soldier1Seen, soldier2Seen, soldier3Seen, soldier4Seen, soldier5Seen;
    bool receivedInfo;
    public int totalMoral;

    //linecast to see, mark bool seen if true, if it is true then pull value, stick value into photo manager

    void Start()
    {
        soldier1Seen = false;
        soldier2Seen = false;
        soldier3Seen = false;
        soldier4Seen = false;
    }


    void Update()
    {
        if (cameraManager.GetComponent<PhotoCapture>().viewingPhoto)
        {
            GetInfo();
            if (!receivedInfo)
            {
               
                receivedInfo = true;
            }
        }
        if (cameraManager.GetComponent<PhotoCapture>().photoRemoved)
        {
            totalMoral = 0;
            soldier1Seen = false;
            soldier2Seen = false;
            soldier3Seen = false;
            soldier4Seen = false;
            soldier5Seen = false;
        }
        else
        {
            receivedInfo = true;
        }
    }

    private void GetInfo()
    {

        if (allsoldiers[0].GetComponent<SoldierState>().canSee && !soldier1Seen)
        {
            totalMoral += allsoldiers[0].GetComponent<SoldierState>().moralValue;
            soldier1Seen = true;
        }
        if (allsoldiers[1].GetComponent<SoldierState>().canSee && !soldier2Seen)
        {
            totalMoral += allsoldiers[1].GetComponent<SoldierState>().moralValue;
            soldier2Seen = true;
        }
        if (allsoldiers[2].GetComponent<SoldierState>().canSee && !soldier3Seen)
        {
            totalMoral += allsoldiers[2].GetComponent<SoldierState>().moralValue;
            soldier3Seen = true;
        }
        if (allsoldiers[3].GetComponent<SoldierState>().canSee && !soldier4Seen)
        {
            totalMoral += allsoldiers[3].GetComponent<SoldierState>().moralValue;
            soldier4Seen = true;
        }
        if (allsoldiers[4].GetComponent<SoldierState>().canSee && !soldier5Seen)
        {
            totalMoral += allsoldiers[4].GetComponent<SoldierState>().moralValue;
            soldier5Seen = true;

        }

    }
}
