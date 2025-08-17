using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Switch.realm == 1f)
        {
            transform.eulerAngles = Vector3.right * 0;
        }
        if(Switch.realm == 0)
        {
            transform.eulerAngles = Vector3.left * 90;
        }
    }
}
