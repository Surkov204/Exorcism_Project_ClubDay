using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    
    private TakeDame takeDame;
    int i = 0;
    private void Awake()
    {
        takeDame = GetComponent<TakeDame>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Word")
        {
            
            // SoundManager.instance.PlaySound(sound);
            // pic.SetActive(true);
            i++;
            Debug.Log(i);
            takeDame.takedamage(i);
            
        }
    }

}
