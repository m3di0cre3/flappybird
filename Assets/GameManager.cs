using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 50;
        Time.timeScale = 1;
    }

    public void GameOverSequence()
    {
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;


        // make game over screen appear
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }


    // add function for button pressing that restarts game

}
