using UnityEngine;
using Mirror;
using Unity.Cinemachine;
using System.Collections;
using System.Collections.Generic;

public class FollowMe : NetworkBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private CinemachineFreeLook cam;
    void Start()
    {
        if (isLocalPlayer)
        {
            cam = CinemachineFreeLook.FindObjectOfType<CinemachineFreeLook>();
            cam.LookAt=this.gameObject.transform;
            cam.Follow=this.gameObject.transform;}
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
