using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FE_GetShoot : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip deathEnemy;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerShoot")
        {
            LifeBarAndScore.playerScore++;
            Destroy(other.gameObject);
            Destroy(gameObject);
            audioSource.PlayOneShot(deathEnemy);
        }    
    }
}
