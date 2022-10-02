using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D col)
    {
        var obj = col.gameObject;
        if (obj.CompareTag("Enemy"))
        {
            Debug.Log("GAME OVER!");
            Time.timeScale = 0;
            GameManager.Instance.GameOver();
        }

        if (obj.CompareTag("Coin"))
        {
            CoinManager.Instance.AddScore(1);
            Destroy(obj);
        }
    }
    
}
