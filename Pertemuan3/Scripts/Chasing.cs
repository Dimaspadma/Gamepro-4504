using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chasing : MonoBehaviour
{
    public GameObject target;

    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(
                transform.position.x + moveSpeed * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }

        if (target.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(
                transform.position.x - moveSpeed * Time.deltaTime,
                transform.position.y,
                transform.position.z);
        }

        if (target.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + moveSpeed * Time.deltaTime,
                transform.position.z);
        }

        if (target.transform.position.y < transform.position.y)
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y - moveSpeed * Time.deltaTime,
                transform.position.z);
        }
        
    }
}
