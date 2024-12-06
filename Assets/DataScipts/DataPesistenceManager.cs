using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

using UnityEngine.UI;
using TMPro;
public class DataPesistenceManager : MonoBehaviour
{
    [Header("File storage Config")]
    [SerializeField] private string fileName;
    

    private GameData gameData;
    private List<IDdataPersistence> dataPresistenceObjects;
    private FileDataHandle fileDataHandle;

    public static DataPesistenceManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("found more than datapresistence in the scene.");
        }
        instance = this;



    }
    public void Start()
    {
        this.fileDataHandle = new FileDataHandle(Application.persistentDataPath, fileName);
        this.dataPresistenceObjects = FindAllDataPersistenceObjects();
        LoadGame();
    }

    public void NewGame()
    {
        this.gameData = new GameData();
    }
    public void LoadGame()
    {
        this.gameData = fileDataHandle.Load();
        if (this.gameData == null)
        {
            Debug.Log("No data was found. Initializing data no defauls");
            NewGame();
        }

        foreach (IDdataPersistence dataPersistencObj in dataPresistenceObjects)
        {
            dataPersistencObj.LoadData(gameData);
        }
      //  Debug.Log("Load scoreValue =" + gameData.scoreValue);


    }

    public void SaveGame()
    {

        foreach (IDdataPersistence dataPersistencObj in dataPresistenceObjects)
        {
            dataPersistencObj.SaveData(ref gameData);
        }
       // Debug.Log("Load scoreValue :3 =" + gameData.scoreValue);
        fileDataHandle.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }
    private List<IDdataPersistence> FindAllDataPersistenceObjects()
    {
        IEnumerable<IDdataPersistence> dataPresistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDdataPersistence>();
        return new List<IDdataPersistence>(dataPresistenceObjects);
    }
}
