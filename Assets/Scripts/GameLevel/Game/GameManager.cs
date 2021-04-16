using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : GameControl
{
    [Header("Game Manager")]
    [SerializeField] string NowSceneName;
    [SerializeField] string NextSceneName;

    public List<GameObject> Bricks;
    public BallObject objectBall;

    [Header("Game Panels")]
    [SerializeField] private GameObject endGamePanel;
    [SerializeField] private GameObject winGamePanel;

    public void RestartGame()
    {
        PlayClickSound();
        SceneManager.LoadScene(NowSceneName);
    }

    public void MainMenu()
    {
        PlayClickSound();
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {
        PlayClickSound();
        SceneManager.LoadScene(NextSceneName);
    }

    private void GetBricks()
    {
        Bricks.Clear();
        foreach (var brick in GameObject.FindGameObjectsWithTag("Brick"))
        {
            Bricks.Add(brick);
        }
    }

    public void EndGame()
    {
        Debug.Log("Oyun Bitti!");
        endGamePanel.SetActive(true);
        winGamePanel.SetActive(false);
    }

    public void WinGame()
    {
        Debug.Log("Tebrikler Oyunu Kazandýn!");
        winGamePanel.SetActive(true);
        endGamePanel.SetActive(false);
    }

    public void ControlBricks()
    {
        GetBricks();
        if (Bricks.Count == 0)
        {
            Debug.Log("Tüm tuðlalarý kýrmayý baþardýn! Tebrikler");
            objectBall = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallObject>();
            objectBall.StopBall();
            WinGame();
        }
    }
}
