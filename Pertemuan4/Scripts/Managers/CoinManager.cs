using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private Coin coinPrefab;

    [SerializeField] private int totalCoin, score;

    [SerializeField] private TextMeshProUGUI scoreText;

    public static CoinManager Instance;

    private void Awake()
    {
        score = 0;
        Instance = this;
    }

    void Start()
    {
        // looping
        for (int i = 0; i < totalCoin; i++)
        {
            // Random x dan y
            var randx = Random.Range(0, 8);
            var randy = Random.Range(5, 10);
        
            // Random 0-49% minus; 50%-100% positif
            var section = Mathf.Repeat(Random.value, 1);

            if (section < 0.5)
            {
                randx *= -1;
            }

            var spawnCoin = Instantiate(coinPrefab, new Vector3(randx, randy, 0), Quaternion.identity);
            spawnCoin.name = $"Coin {i+1}";
        }

    }

    public void AddScore(int newScore)
    {
        score += newScore;
        scoreText.text = score.ToString();
    }
}
