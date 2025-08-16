using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spielerb : MonoBehaviour
{
    public float jumpforce=5f;
    public float movespeed=10f;
    // Start is called before the first frame update
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
            transform.Translate(Vector2.right * Time.deltaTime * movespeed);
        }
        if(Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * Time.deltaTime * movespeed);
        }
    }
}
