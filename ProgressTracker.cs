using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProgressTracker : MonoBehaviour
{
    private AudioSource Player;
    private bool IsPlaying = false;
    public int CurrentWP= 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
