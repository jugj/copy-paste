using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemyFollow : MonoBehaviour
{
    public float jumpforce = 50;
    public float movespeed = 0.0025f;
    public GameObject player;
    public float wait = 10f; 
    public float timer = 0f;

    void Start()
    {
    }

    void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log("E tp: " + transform.position + " P tp: " + player.transform.position + " d: " + distanceToPlayer);
        if (distanceToPlayer > 0)
        {
            Vector2 direction = ((Vector2)player.transform.position - (Vector2)transform.position).normalized;
            Vector2 velocity = direction * movespeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x, transform.position.y) + velocity;
            
            
        }  
        if (timer < wait)
        {
            timer = timer + Time.deltaTime;
            return;
            int punktestand = Random.Range(0, 9);
         if (punktestand == 5) {
            transform.Translate(Vector2.up * Time.deltaTime * jumpforce);
        }
        timer = 0f;
         }
     }
     
}