using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenerateObs : MonoBehaviour
{
    public GameObject rocks;

    private int _score;
    void Start()
    {
        InvokeRepeating("GenerateObstacle", 2, 3);
    }

    void GenerateObstacle()
    {
        var rock = Instantiate(rocks);
        var pos = transform.position;
        var rand = Random.Range(0f, 3f);
        pos.y = (Random.Range(0,2) % 2 == 0) ? rand : -rand;
        rock.transform.position = pos;

        _score++;
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        var text = $"Score {_score}";
        GUILayout.Label(text);
    }
}
