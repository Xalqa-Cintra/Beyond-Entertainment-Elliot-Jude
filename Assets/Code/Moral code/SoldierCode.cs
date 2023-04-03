using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierCode : MonoBehaviour
{

    public GameObject cameraManager;

    public GameObject[] allsoldiers;

    public bool soldier1Seen, soldier2Seen, soldier3Seen, soldier4Seen;
    public int totalMoral;

    //linecast to see, mark bool seen if true, if it is true then pull value, stick value into photo manager

    void Start()
    {

    }


    void Update()
    {
        if (cameraManager.GetComponent<PhotoCapture>().viewingPhoto)
        {GetInfo();}
    }

    private void GetInfo()
    {
        {
            if (allsoldiers[0].GetComponent<SoldierState>().canSee)
            {
                totalMoral += allsoldiers[0].GetComponent<SoldierState>().moralValue;
                soldier1Seen = true;
            }
            if (allsoldiers[1].GetComponent<SoldierState>().canSee)
            {
                totalMoral += allsoldiers[1].GetComponent<SoldierState>().moralValue;
                soldier2Seen = true;
            }
            if (allsoldiers[2].GetComponent<SoldierState>().canSee)
            {
                totalMoral += allsoldiers[2].GetComponent<SoldierState>().moralValue;
                soldier3Seen = true;
            }
            if (allsoldiers[3].GetComponent<SoldierState>().canSee)
            {
                totalMoral += allsoldiers[3].GetComponent<SoldierState>().moralValue;
                soldier4Seen = true;
            }
        }
    }

}
