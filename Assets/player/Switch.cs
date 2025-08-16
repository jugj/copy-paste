using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool isshadowrealm = false;
    public static float realm = 0;
    float wait = 1f;
    float timescinelaste = 0f;
    public int test = 0;

    void Start()
    {
        isshadowrealm = false;
        Debug.Log(realm);
    }
    // Update is called once per frame
    void Update()
    {
        if(timescinelaste < wait)
        {
            timescinelaste = timescinelaste + Time.deltaTime;
            return;
        }
        if(Input.GetKey("e"))
        {
            if (!isshadowrealm)
            {
            isshadowrealm = true;
            realm = 1;
            Debug.Log(realm);
            timescinelaste = 0f;
            }
            else
            {
            isshadowrealm = false;
            realm = 0;
            Debug.Log(realm);
            timescinelaste = 0f;
            }
        }
         
    }
}
