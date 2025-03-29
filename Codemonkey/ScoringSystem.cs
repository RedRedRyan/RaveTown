using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
     
    void Update()
    {
        scoreText.GetComponent<Text>().text = "" + theScore;

    }
}
