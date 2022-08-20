using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueScript : MonoBehaviour
{
    Animator anim;
    void Start(){
        anim = GameObject.Find("tongue").GetComponent<Animator>();
    }

   public void PlayTongueLeft(){
        anim.Play("extension_left");
   }
  public void PlayTongueRight(){
        anim.Play("extension_right");
   }

}
