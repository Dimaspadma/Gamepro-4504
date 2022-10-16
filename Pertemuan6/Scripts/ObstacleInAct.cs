using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInAct : MonoBehaviour
{
    public float offsetX;
    
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < offsetX) Destroy(gameObject);
    }
}
