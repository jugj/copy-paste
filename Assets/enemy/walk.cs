using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XEnemyFollow : MonoBehaviour
{
    public float movespeed = 3f;
    public GameObject player;
    public Switch Switch;
    float timer = 0f;

    void Start()
    {
    }

    void Update()
    {   if(Switch.isshadowrealm == true)
        {
            if (player == null) return;

            float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
            if (distanceToPlayer <= 10)
            {
                Vector2 direction = ((Vector2)player.transform.position - (Vector2)transform.position).normalized;
                Vector2 velocity = direction * movespeed * Time.deltaTime;
                transform.position = new Vector2(transform.position.x, transform.position.y) + velocity;
            }   
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit enter");
        player.GetComponent<playerbewegung>().bekommeschaden(15);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        timer += Time.deltaTime;
        if(timer > 0.75f){
            Debug.Log("hit stay");
            player.GetComponent<playerbewegung>().bekommeschaden(15);
        }
    }

    void OnCollisionExit2D(){
        timer = 0f;
    }
}