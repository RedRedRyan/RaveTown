using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public int Position = 0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            Debug.Log("Hit");
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if(CarTracking<WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                Debug.Log("CurrentWP"+ other.GetComponent<ProgressTracker>().CurrentWP);
                Position++;
                SaveScript.PlayerPosition = Position;
            }
           
        }
    }
   
}
