using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug : MonoBehaviour
{
    public GameObject player;
    //public float x, y, z = 0f;
    
    public void teleportPlayer()
    {
        //Vector3 pos = player.transform.position;
        print(player.transform.position);
        //player.transform.position = new Vector3(x, y, z);
        //pos = player.transform.position;
        //print(pos);
    }
}
