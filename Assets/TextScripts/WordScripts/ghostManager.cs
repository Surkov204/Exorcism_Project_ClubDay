using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostManager : MonoBehaviour
{
    public static ghostManager instance;
    [SerializeField] private GameObject ghost1;
    [SerializeField] private GameObject ghost2;
    [SerializeField] private GameObject ghost3;
    [SerializeField] private AudioSource HeartBeatSound;
    private int misscount = 0;
    private void Awake()
    {
        instance = this;

    }
    public void GhostMove(int currentMisscount)
    {
        misscount = currentMisscount;
        if (misscount == 1 && !ghost1.activeInHierarchy)
        {
            ghost1.SetActive(true);
            HeartBeatSound.Play();
            HeartBeatSound.volume = 0.2f;
        } 
        if (misscount == 20 && !ghost2.activeInHierarchy)
        {
            ghost1.SetActive(false);
            ghost2.SetActive(true);
            HeartBeatSound.volume = 0.4f;
        }
        if (misscount == 40 && !ghost3.activeInHierarchy)
        {
            ghost2.SetActive(false);
            ghost3.SetActive(true);
            HeartBeatSound.volume = 1f;
        }
    }

}
