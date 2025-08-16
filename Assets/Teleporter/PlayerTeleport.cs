using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    float wait = 1f;
    float waitbutshort = 0.5f;
    private GameObject currentTeleporter;
    void Update()
    {
        if(waitbutshort < wait)
        {
            waitbutshort = waitbutshort + Time.deltaTime;
            return;
        }
        if(Input.GetKey("r"))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
            waitbutshort = 0.5f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            if (collision.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
                waitbutshort = 0.5f;
            }
        }
    }
}