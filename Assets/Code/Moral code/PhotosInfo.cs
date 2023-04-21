using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotosInfo : MonoBehaviour
{
    public GameObject soldierManager;
    public int photoValue;

    public void FindInfo()
    {
        photoValue = soldierManager.GetComponent<SoldierCode>().totalMoral;

    }
    //retrieve info from soldier manager
    //put into this code for each photo fromdarkroommanager
}
