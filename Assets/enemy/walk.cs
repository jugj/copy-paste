using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XEnemyFollow : MonoBehaviour
{
    public float movespeed = 3f;
    public GameObject player;

    void Start()
    {
    }

    void Update()
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
      void OnCollisionEnter2D(Collision2D other)
     {
        player.GetComponent<playerbewegung>().bekommeschaden(15);
     }
}