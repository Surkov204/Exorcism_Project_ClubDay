using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBegin : MonoBehaviour
{
    public GameObject background;
    public GameObject timeCount;
    public GameObject Score;
    public GameObject MissCount;
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void StartGame()
    {
        background.SetActive(false);
        timeCount.SetActive(true);
        Score.SetActive(true);
        MissCount.SetActive(true);
        Time.timeScale = 1;
    }
}
