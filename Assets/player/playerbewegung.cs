using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbewegung : MonoBehaviour
{
    public float jumpforce = 5f;
    public float movementspeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
        {
            transform.Translate(Vector2.up * Time.deltaTime * jumpforce);
        }
        if(Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * Time.deltaTime * movementspeed);
        }
        if(Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * movementspeed);
        }
    }
}
