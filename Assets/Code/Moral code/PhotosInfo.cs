using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosInfo : MonoBehaviour
{
    public GameObject soldierManager;
    public int photoValue;
    public bool[] soldierSeen;
    public bool selected;

    public void FindInfo()
    {
        photoValue = soldierManager.GetComponent<SoldierCode>().totalMoral;

        soldierSeen[0] = soldierManager.GetComponent<SoldierCode>().soldier1Seen;
        soldierSeen[1] = soldierManager.GetComponent<SoldierCode>().soldier2Seen;
        soldierSeen[2] = soldierManager.GetComponent<SoldierCode>().soldier3Seen;
        soldierSeen[3] = soldierManager.GetComponent<SoldierCode>().soldier4Seen;
        soldierSeen[4] = soldierManager.GetComponent<SoldierCode>().soldier5Seen;
    }


    //retrieve info from soldier manager
    //put into this code for each photo fromdarkroommanager
}
