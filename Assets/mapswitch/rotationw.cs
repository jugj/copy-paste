using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        if(Switch.realm == 1)
        {
            transform.eulerAngles = Vector3.left * 90;
        }
        if(Switch.realm == 0)
        {
            transform.eulerAngles = Vector3.left * 0;
        }
    }
}
