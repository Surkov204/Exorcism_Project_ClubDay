using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering;
public class wordDisplay : MonoBehaviour
{
    public Text text;
    public float fallSpeed =1f;
    private float timeCounter = 0;
   [SerializeField] private float timeSpeedUp = 12f;
   [SerializeField] private float acceleration = 0.02f;

    public void SetWord(string word)
    {
        text.text = word;
    }
    public void RemoveLetter()
    {
        text.text = text.text.Remove(0,1);
      
        text.color = Color.red;
    }
    public void RemoveWord()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        timeCounter += Time.deltaTime;
        if (timeCounter >= timeSpeedUp)
        {
            fallSpeed += acceleration;
            timeCounter = 0;
        }
    }
  
}
