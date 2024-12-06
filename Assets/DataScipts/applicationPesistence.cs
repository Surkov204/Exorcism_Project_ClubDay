using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applicationPesistence : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Application.persistentDataPath);
    }
}
