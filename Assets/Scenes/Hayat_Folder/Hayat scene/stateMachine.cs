using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stateMachine : MonoBehaviour
{
    [SerializeField] GameObject StartCanvas;
    [SerializeField] GameObject restartCanvas;
    [SerializeField]int StartScene;
    [SerializeField] int gameScene;

    void Start()
    {
        //restartCanvas.SetActive(false);

    }
    public void Startgame()
    {
        Time.timeScale = 0;
        //StartCanvas.SetActive(true);
        
    }
    public void CurrentGame()
    {
        Time.timeScale = 1;
        //StartCanvas.SetActive(false);
        SceneManager.LoadScene(gameScene);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene(StartScene);
        // StartCanvas.SetActive(false);
        //restartCanvas.SetActive(true);

    }

}
