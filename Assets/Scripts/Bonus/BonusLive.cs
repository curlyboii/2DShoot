using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusLive : MonoBehaviour
{

    [SerializeField] private Health health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (health.currentLives < 5)
            {
                health.currentLives += 1;
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("You have maximum lives!");
            }
        }
    }
}
