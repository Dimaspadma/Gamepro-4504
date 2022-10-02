using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 _kebawah;
    void Start()
    {
        _kebawah = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _kebawah * (speed * Time.deltaTime);
    }
}
