using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class UIScript : MonoBehaviour
{
    public Text LapNumberText;
    public Text TotalLapsText;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;
    public Text RaceTimeMinutesText;
    public Text RaceTimeSecondsText;
    public Text BestLapTimeMinutes;
    public Text BestLapTimeSeconds;

    public Text TotalCarsText;
    public Text PlayersPosition;


    public Text TimeTrialMinutesG;
    public Text TimeTrialSecondsG;
    public Text TimeTrialMinutesS;
    public Text TimeTrialSecondsS;
    public Text TimeTrialMinutesB;
    public Text TimeTrialSecondsB;

    public int TotalLaps;
    public int TotalCars = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();
        TotalCarsText.text="/" + TotalCars.ToString();
        PlayersPosition.text = "1";
    }

    // Update is called once per frame
    void Update()
    {
          //Setting Timetrial Gold
        if(SaveScript.TimeTrialMinG <= 9)
        {
            TimeTrialMinutesG.text = "0" + SaveScript.TimeTrialMinG.ToString() + " :";
        
        }
        if (SaveScript.TimeTrialMinG >= 10)
        {
            TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString() + " :";
        }

        if (SaveScript.TimeTrialSecondsG <= 9)
        {
            TimeTrialSecondsG.text = "0" + SaveScript.TimeTrialSecondsG.ToString();
        }
        if (SaveScript.TimeTrialSecondsG >= 10)
        {
            TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString();
        }

        //Setting Timetrial Silver
        if (SaveScript.TimeTrialMinS <= 9)
        {
            TimeTrialMinutesS.text = "0" + SaveScript.TimeTrialMinS.ToString() + " :";
        }
         if (SaveScript.TimeTrialMinS >= 10)
        {
            TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString() + " :";
        }
        if (SaveScript.TimeTrialSecondsS <= 9)
        {
            TimeTrialSecondsS.text = "0" + SaveScript.TimeTrialSecondsS.ToString();
        }
         if (SaveScript.TimeTrialSecondsS >= 10)
        {
            TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString();
        }

        //Setting Timetrial Bronze
        if (SaveScript.TimeTrialMinB <= 9)
        {
            TimeTrialMinutesB.text = "0" + SaveScript.TimeTrialMinB.ToString() + " :";
        }
         if (SaveScript.TimeTrialMinB >= 10)
        {
            TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString() + " :";
        }
        if (SaveScript.TimeTrialSecondsB <= 9)
        {
            TimeTrialSecondsB.text = "0" + SaveScript.TimeTrialSecondsB.ToString();
        }
         if (SaveScript.TimeTrialSecondsB >= 10)
        {
            TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString();
        }


       //LapNumber
        LapNumberText.text = SaveScript.LapNumber.ToString();

        //LapTime
        if (SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + " :";
        }
         if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + " :";
        }
        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
         if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }

        //RaceTime
        if (SaveScript.RaceTimeMinutes <= 9)
        {
            RaceTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + " :";
        }
         if (SaveScript.RaceTimeMinutes >= 10)
        {
            RaceTimeMinutesText.text = (Mathf.Round(SaveScript.RaceTimeMinutes).ToString()) + " :";
        }
        if (SaveScript.RaceTimeSeconds <= 9)
        {
            RaceTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }
         if (SaveScript.RaceTimeSeconds >= 10)
        {
            RaceTimeSecondsText.text = (Mathf.Round(SaveScript.RaceTimeSeconds).ToString());
        }

        //Best Laptime
        if (SaveScript.LastLapM == SaveScript.BestLapTimeM)
        {
            if (SaveScript.LastLapS < SaveScript.BestLapTimeS)
            {
                SaveScript.BestLapTimeS = SaveScript.LastLapS;
            }
        }
        if (SaveScript.LastLapM < SaveScript.BestLapTimeM)
        {
            SaveScript.BestLapTimeM = SaveScript.LastLapM;
            SaveScript.BestLapTimeS = SaveScript.LastLapS;
        }

        //BestLapTimeDisplay
        if (SaveScript.BestLapTimeM <= 9)
        {
            BestLapTimeMinutes.text = "0" + (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + " :";
        }
         if (SaveScript.BestLapTimeM >= 10)
        {
            BestLapTimeMinutes.text = (Mathf.Round(SaveScript.BestLapTimeM).ToString()) + " :";
        }
        if (SaveScript.BestLapTimeS <= 9)
        {
            BestLapTimeSeconds.text = "0" + (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }
         if (SaveScript.BestLapTimeS >= 10)
        {
            BestLapTimeSeconds.text = (Mathf.Round(SaveScript.BestLapTimeS).ToString());
        }
        if (SaveScript.NewRecord == true)
        {
            StartCoroutine(LapRecordOff());
        }
        IEnumerator LapRecordOff()
        {
            yield return new WaitForSeconds(2);
            SaveScript.NewRecord = false;
        }
        PlayersPosition.text=SaveScript.PlayerPosition.ToString();

    }
}
