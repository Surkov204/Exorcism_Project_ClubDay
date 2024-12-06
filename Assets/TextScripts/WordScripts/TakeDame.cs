using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TakeDame : MonoBehaviour
{
    public AudioClip sound;
    public GameObject pic;
    public AudioClip soundJumpscare;
    private WordManager wordManager;
    
    public void takedamage(int _damage)
    {
       // if (_damage > 0)
        //{
          //  SoundManager.instance.PlaySound(sound);
       // }

        if (_damage == 1)
        {
            Time.timeScale = 0;
            SoundManager.instance.PlaySound(soundJumpscare);
            pic.SetActive(true);
           
        }

    }
  
}
