using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Backtogame : MonoBehaviour
{
    public GameObject pic;
    private WordManager wordManager;
    public GameObject background;
    public GameObject Soundmanager;
    public GameObject MainGame;
    public string sceneName;
    public void BacktoGame()
    {
        pic.SetActive(false);
    }    
    public void EnterContent()
    {
        pic.SetActive(true);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void LoadNextScene()
    {
 
        StartCoroutine(UnloadCurrentSceneAndLoadNewScene(sceneName));
    }
    private IEnumerator UnloadCurrentSceneAndLoadNewScene(string sceneName)
    {
      
        yield return SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

        background.SetActive(false);
        MainGame.SetActive(false);
        Soundmanager.SetActive(false);
       
        SceneManager.LoadScene("EndScene", LoadSceneMode.Additive);
        Time.timeScale = 1;
    }
}
