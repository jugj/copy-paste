using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbewegung : MonoBehaviour
{
    public float jumpforce = 10f;
    public float movementspeed = 10f;
    public int Health = 100;
    public int Healthp = 100;
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
        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
        if(Health != Healthp)
        {
            Debug.Log(Health);
        }
        if(Health != Healthp)
        {
            Healthp = Health;
        }
    }

    public void bekommeschaden(int schaden)
    {
        Health = Health - schaden;
        if(Health <= 0)
        {
            Debug.Log("der spieler ist tot");
        }
    }
}
