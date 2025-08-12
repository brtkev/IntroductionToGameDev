using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public Player player;
    public Text pointsText;
    public Text gameOverText;
    public void Setup(int score, string message)
    {
        gameObject.SetActive(true);
        pointsText.text = "Score: "+ score.ToString();
        gameOverText.text = message;
        Destroy(player.gameObject);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
