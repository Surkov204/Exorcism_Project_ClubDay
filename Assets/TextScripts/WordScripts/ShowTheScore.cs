using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowTheScore : MonoBehaviour
{
    public TextMeshProUGUI CurrentScore;
    public TextMeshProUGUI HighScore;
    private void Start()
    {
        HighScore.text = " " + CurrentScore;
    }
    private void Update()
    {
        HighScore.text = " " + CurrentScore;
    }
}

