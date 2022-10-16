using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateCoin : MonoBehaviour
{
    public static GenerateCoin Instance;
    public GameObject coin;

    private int _coin;
    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        InvokeRepeating("Generate", 1, 2);
    }

    void Generate()
    {
        var spawnCoin = Instantiate(coin);
        var pos = transform.position;
        var rand = Random.value * 10;
        pos.y = rand - 5;
        spawnCoin.transform.position = pos;
    }

    public void IncrementCoin()
    {
        _coin++;
    }
    
    private void OnGUI()
    {
        GUI.color = Color.black;
        var text = $"\nCoin {_coin}";
        GUILayout.Label(text);
    }
}
