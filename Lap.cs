using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(SaveScript.RaceOver==false)
            {
                if (SaveScript.HalfWayActivated==true)
            {
                SaveScript.HalfWayActivated = false;
                SaveScript.LastLapM = SaveScript.LapTimeMinutes;
                SaveScript.LastLapS = SaveScript.LapTimeSeconds;
                SaveScript.LapNumber++;
                // SaveScript.LapTimeMinutes = 0f;

                SaveScript.LapChange = true;
                if (SaveScript.LapNumber == 2)
                {
                    SaveScript.BestLapTimeM = SaveScript.LastLapM;
                    SaveScript.BestLapTimeS = SaveScript.LastLapS;
                    SaveScript.NewRecord=true;
                }
            }
            }
        }
    }
}
