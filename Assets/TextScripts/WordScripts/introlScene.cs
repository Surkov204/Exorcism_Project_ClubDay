using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public GameObject imageObject;  // Thay đổi sang GameObject
    public GameObject textObject;   // Thay đổi sang GameObject
    [SerializeField] private float displayTime  ;

    void Start()
    {
        ShowImage();
    }

    void ShowImage()
    {
        Debug.Log("showing");
        imageObject.SetActive(true);
        textObject.SetActive(true);
        Invoke("hideImage", displayTime);

    }
    void hideImage()
    {
        Debug.Log("notshowing");
        imageObject.SetActive(false);
        textObject.SetActive(false);
        SceneManager.LoadScene("Chapter1");



    }
}