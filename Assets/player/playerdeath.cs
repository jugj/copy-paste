using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdeath : MonoBehaviour
{
    public GameObject player;
    public static Vector3 checkpoint;
    public static  bool respawn1 = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerbewegung.Health <= 0)
        {
            transform.position = checkpoint;
            playerbewegung.Health = 100;
        }
    }
}
