using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject gameOverText;

    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
    }
}
