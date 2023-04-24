using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoarding : MonoBehaviour
{
    
    private Transform transform:
    private Position position;
    GameObject player;

    private void Start() 
    {
        player = GameObject.Find("player");
    }
    private void Update()
    {
        this.transform.Look(new Vector3(player.position.x, this.Position.y, player.Position.z));
    }
}
