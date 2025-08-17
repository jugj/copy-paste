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
        Debug.Log("E tp: " + transform.position + " P tp: " + player.transform.position + " d: " + distanceToPlayer);
        if (distanceToPlayer <= 5)
        {
            Vector2 direction = ((Vector2)player.transform.position - (Vector2)transform.position).normalized;
            Vector2 velocity = direction * movespeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x, transform.position.y) + velocity;
        }   
     }
}