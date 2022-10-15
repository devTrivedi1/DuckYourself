using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stateMachine : MonoBehaviour
{
    [SerializeField] GameObject StartCanvas;
    [SerializeField] GameObject restartCanvas;

    void Start()
    {
        restartCanvas.SetActive(false);

    }
    public void Startgame()
    {
        Time.timeScale = 0;
        StartCanvas.SetActive(true);
        
    }
    public void CurrentGame()
    {
        Time.timeScale = 1;
        StartCanvas.SetActive(false);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        StartCanvas.SetActive(false);
        restartCanvas.SetActive(true);
    }

}
