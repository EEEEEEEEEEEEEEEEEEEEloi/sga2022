using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    AudioSource audio;

    void Start(){
         audio= GetComponent<AudioSource>();
    }
    
   public void PlayWinSound (){
    audio.Play();
   }
}
