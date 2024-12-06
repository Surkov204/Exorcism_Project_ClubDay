using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static Audio instance { get; private set; }
    private AudioSource soundSource;
 
    private void Awake()
    {
        soundSource = GetComponent<AudioSource>();
       
    }
    public void PlaySound(AudioClip _sound)
    {
        soundSource.PlayOneShot(_sound);
    }
}
