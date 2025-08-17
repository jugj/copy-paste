using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler : MonoBehaviour
{
    public int MaxLeben = 10;
    public int JetztLeben;
    public Lebensanzeige lebensanzeige;

    // Start is called before the first frame update
    void Start()
    {
        JetztLeben = MaxLeben;
        lebensanzeige.SetzeMaxLeben(MaxLeben);
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKeyDown("s")){//Wenn Spieler Schaden dann Code unten nutzen
        JetztLeben -= 1;
        lebensanzeige.setzeLeben(JetztLeben);
    }
        
    }
}
