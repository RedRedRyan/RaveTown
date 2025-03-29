using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class teleport : MonoBehaviour
{
    public  Transform player, destination;
    public GameObject playerg;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           playerg.SetActive(false);
           player.position = destination.position;
            playerg.SetActive(true);
        }
    }
}
