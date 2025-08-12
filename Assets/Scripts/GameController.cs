using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float playerHealthPoints = 3f;
    public float maxScore = 3f;
    private int currentScore = 0;
    public GameOverScreen gameOverScreen;
    public string gameOverText = "Game Over";
    public string congratulationsText = "Congratulations you've won!";
    

    public void RemovePlayerHealthPoints(int damagePoints = 1)
    {
        playerHealthPoints -= damagePoints;
        Debug.Log("Current player HP " + playerHealthPoints.ToString());
        if (playerHealthPoints <= 0)
        {
            Debug.Log("Game Over Screen!");
            gameOverScreen.Setup(currentScore, gameOverText);
        }
    }

    public void AddScore(int score)
    {
        currentScore += score;
        Debug.Log("Current Score " + currentScore.ToString());

        if (currentScore >= maxScore)
        {
            Debug.Log("Congratulations Screen!");
            gameOverScreen.Setup(currentScore, congratulationsText);
        }
    }
}
