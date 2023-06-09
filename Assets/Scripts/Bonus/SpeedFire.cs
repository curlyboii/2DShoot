using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFire : MonoBehaviour
{
    [SerializeField] private ShootingController shootingController;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            shootingController.fireRate -= 0.02f;
            Destroy(gameObject);
        }
    }
}
