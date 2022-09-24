using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    public float moveSpeed;
    [SerializeField] private Vector3 kekanan, kekiri, keatas, kebawah;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + kekanan * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position +=  kekiri * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += keatas * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += kebawah * (moveSpeed * Time.deltaTime);
        }
    }
}
