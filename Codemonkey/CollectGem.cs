using UnityEngine;

public class CollectGem : MonoBehaviour
{
    
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoringSystem.theScore += 1;
        Destroy(gameObject);

    }
}
