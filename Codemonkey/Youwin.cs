using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class Youwin : MonoBehaviour
{
   public GameObject Youwinpanel;
   
   
   private void OnTriggerEnter(Collider other){
   Debug.Log("hit");
   
  
   Youwinpanel.SetActive(true);
        
        Time.timeScale = 0f;
    }
}
   

