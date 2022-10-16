using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool isJumpPressed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * 300);
            // Debug.Log("jump");
        }
        
        // Player position in world into screen
        var playerPos = Camera.main.WorldToScreenPoint(transform.position);
        if (playerPos.y > Screen.height || playerPos.y < 0)
            Die();
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Obstacle"))
        {
            Die();
        }

        if (col.CompareTag("Coin"))
        {
            GenerateCoin.Instance.IncrementCoin();
            Destroy(col.gameObject);
        }
    }

    void Die()
    {
        Debug.Log("Game over");
        SceneManager.LoadScene("SampleScene");
    }
}
