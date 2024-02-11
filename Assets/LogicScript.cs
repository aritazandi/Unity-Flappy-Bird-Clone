using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int Score;
    public Text ScoreText;
    public GameObject gameOverScreen;
    [ContextMenu("increase")]
    public void addScore()
    {
        Score += 1;
        ScoreText.text = Score + "";
    }
    public void restartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
