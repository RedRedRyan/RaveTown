using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class OTLoadLevel : MonoBehaviour
{
public GameObject guiObject;
public string levelToLoad;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        guiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
       if(other.gameObject.tag == "Player")
       {
        guiObject.SetActive(true);
        if(guiObject.activeInHierarchy==true && Input.GetButtonDown("Use"))
        {
            Application.LoadLevel(levelToLoad);
        }
       }
    }
    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
