using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            // Setze die neue Position
            collision.gameObject.transform.position = new Vector2(-9.554f, 2.395f);
        }
    }
}