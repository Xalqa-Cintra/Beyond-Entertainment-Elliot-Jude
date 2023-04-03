using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierState : MonoBehaviour
{
    // each soldier own values
    public bool moral;
    public bool immoral;
    public bool neutral;

    public int moralValue;

    public bool canSee;


    public LayerMask npcLayer;
    public GameObject player;

    //set value to bools depending on rng maybe, most likely jus predetermined for now


    private void OnBecameVisible()
    {
        CheckIfSeen();
    }

    void CheckIfSeen()
    {
      if(Physics.Linecast(player.transform.position, this.transform.position, npcLayer))
        {
            canSee= false;
            Debug.DrawLine(player.transform.position, this.transform.position, Color.green, 15, false);
            Debug.Log("Blocked");
        }else
        {
            canSee= true;
        }
    }
}
