using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CheckpointSingle : MonoBehaviour
{
    private TrackCheckpoints trackCheckpoints;
    private MeshRenderer meshRenderer;
    private void Awake()
    
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start()
    {
        Hide();
    }
       
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            trackCheckpoints.PlayerThroughCheckpoint(this);
        }
    }
    public void SetTrackCheckpoints(TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
    public void Show()
    {
        meshRenderer.enabled = true;
    }
    public void Hide()
    {
        meshRenderer.enabled = false;
    }

}
