using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObjek : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;
    
    private Vector3 _kekanan, _kekiri, _keatas, _kebawah;
    // Start is called before the first frame update
    void Awake()
    {
        _kekanan = new Vector3(1, 0, 0);
        _kekiri = new Vector3(-1, 0, 0);
        _keatas = new Vector3(0, 1, 0);
        _kebawah = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + _kekanan * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.position +=  _kekiri * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += _keatas * (moveSpeed * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += _kebawah * (moveSpeed * Time.deltaTime);
        }
    }
}
