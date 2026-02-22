using TMPro;
using UnityEngine;
using System;


public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameManager manager = FindFirstObjectByType<GameManager>();
        scoreText.text = manager.player2Score.Value.ToString() + " - " + manager.player1Score.Value.ToString();

        if (manager.player1Score.Value >= 5)
        {
          Debug.Log("Player 1 Win!");
           scoreText.text = "Player 1 Win!";
        }
        if  (manager.player2Score.Value >= 5)
        {
          Debug.Log("Player 2 Win!");
          scoreText.text = "Player 2 Win!";
        }

        
    }
}
