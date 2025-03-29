using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RaceType : MonoBehaviour
{
    public bool TimeTrial;
    public float GoldMin;
    public float GoldSec;
    public float SilverMin;
    public float SilverSec;
    public float BronzeMin;
    public float BronzeSec; 

    public GameObject GoldMedal;
    public GameObject SilverMedal;
    public GameObject BronzeMedal;
    public GameObject FailMedal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(TimeTrial == true)
        {
            SaveScript.TimeTrialMinG = GoldMin;
            SaveScript.TimeTrialSecondsG = GoldSec;
            SaveScript.TimeTrialMinS = SilverMin;
            SaveScript.TimeTrialSecondsS = SilverSec;
            SaveScript.TimeTrialMinB = BronzeMin;
            SaveScript.TimeTrialSecondsB = BronzeSec;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SaveScript.RaceOver == true )
        {
        //Gold minutes
    if(SaveScript.RaceTimeMinutes<GoldMin)
    {
        GoldMedal.SetActive(true);
        SaveScript.Gold=true;
    }
    if(SaveScript.RaceTimeMinutes == GoldMin && SaveScript.RaceTimeSeconds<GoldSec)
    {
        GoldMedal.SetActive(true);
        SaveScript.Gold=true;
    }
     //Silver minutes
    if(SaveScript.RaceTimeMinutes<SilverMin)
    {
        if(SaveScript.Gold==false)
        {
        SilverMedal.SetActive(true);
        SaveScript.Silver=true;
        }
    }
    if(SaveScript.RaceTimeMinutes == SilverMin && SaveScript.RaceTimeSeconds<SilverSec)
    {
         if(SaveScript.Gold==false)
        {
        SilverMedal.SetActive(true);
        SaveScript.Silver=true;
        }
    }
     //Bronze minutes
    if(SaveScript.RaceTimeMinutes<BronzeMin)
    {
         if(SaveScript.Gold==false && SaveScript.Silver == false)
        {
        BronzeMedal.SetActive(true);
        SaveScript.Bronze=true;
        }
    if(SaveScript.RaceTimeMinutes == BronzeMin && SaveScript.RaceTimeSeconds<BronzeSec)
    {
        if(SaveScript.Gold==false && SaveScript.Silver == false)
        {
        BronzeMedal.SetActive(true);
        SaveScript.Bronze=true;
        }
            
            //Fail
            else if(SaveScript.Gold == false && SaveScript.Silver == false && SaveScript.Bronze == false)
            {
                FailMedal.SetActive(true);
                SaveScript.Fail=true;
            }

    }    }
    }
    }
}
