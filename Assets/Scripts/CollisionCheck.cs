using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public GameController gameController;
    public int coinValue = 1;
    public int enemyDamage = 1;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Trigger with Coin detected!");
            Destroy(trigger.gameObject);
            gameController.AddScore(coinValue);
        }else if (trigger.gameObject.CompareTag("Enemy"))
        {
            Destroy(trigger.gameObject);
            gameController.RemovePlayerHealthPoints(enemyDamage);
        }
    }
    
}
