using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class TimeCount : MonoBehaviour
{
    public TextMeshProUGUI TimeBox;
   
  
    public float TimeStart = 0.5f;

    private void Start()
    {
        TimeBox.text ="Time: " + TimeStart.ToString();
    }
    private void Update()
    {
        TimeStart += Time.deltaTime;
        TimeBox.text = "Time: "+Mathf.Round(TimeStart).ToString();
    }
}
  
