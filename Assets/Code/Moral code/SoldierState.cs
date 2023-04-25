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
    public bool inView;


    public LayerMask npcLayer;
    public GameObject player;
    public GameObject manager;
    public GameObject maxView;

    //set value to bools depending on rng maybe, most likely jus predetermined for now
    private void Start()
    {
        if (moral)
        {
            moralValue = Random.Range(1, 10);
        }
        if (immoral)
        {
            moralValue = Random.Range(-1, -10);
        }
        if (neutral)
        {
            moralValue = Random.Range(-3, 3);
        }
    }

    private void OnBecameVisible()
    {
        CheckIfSeen();
        if(canSee)
        {
            Debug.Log(moralValue);
        }
        else
        {
            Debug.Log("Can't See");
        }
    }
    private void OnBecameInvisible()
    {
        canSee = false;
    }

    void CheckIfSeen()
    {
        if (Physics.Linecast(player.transform.position, this.transform.position, npcLayer))
        {
            canSee = false;
            Debug.DrawLine(player.transform.position, this.transform.position, Color.green, 15, false);
            Debug.Log("Blocked");
        }
        else
        {
            canSee = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "inView") { inView = true; }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "inView") { inView = false; }
    }
}
