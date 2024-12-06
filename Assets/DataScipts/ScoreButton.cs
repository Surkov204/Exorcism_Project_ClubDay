
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class ScoreButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    public static ScoreButton instance { get; private set; }
    int score = 0;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        LoadGame();
    }
    public void Update()
    {
    
        scoreText.text = "Score: " + score.ToString();

    }
    public void Deactivate()
    {
        score++;
        UnityEngine.Debug.Log(score);
        
    }
    public void Minus()
    {
        if (score > 0)
        {
            score--;
        } 
    }
    public void resetScore()
    {
        if (score > 0)
        {
            score = 0;
        }
    }
    public void SaveGame()
    {
        GameData data = new GameData();
        data.Score = score;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.persistentDataPath + "/tuananh1.json", json);

    }
    public void LoadGame()
    {

        string json = File.ReadAllText(Application.persistentDataPath + "/tuananh1.json");
        GameData data = JsonUtility.FromJson<GameData>(json);
        score = data.Score;
      

    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
}

