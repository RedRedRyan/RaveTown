using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Activator : MonoBehaviour
{
    public GameObject FinishPoint;
    public UIScript ui;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Progress")
        {
            SaveScript.HalfWayActivated=true;

            Debug.Log(SaveScript.LapNumber);
            
            if(SaveScript.LapNumber == SaveScript.MaxLaps)
            {
                FinishPoint.SetActive(true);
            }
        }
    }
}
