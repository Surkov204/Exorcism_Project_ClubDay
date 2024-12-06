using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDdataPersistence
{
    void LoadData(GameData data);

    void SaveData(ref GameData data);
}
