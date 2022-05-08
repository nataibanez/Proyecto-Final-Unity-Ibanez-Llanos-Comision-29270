using System;
using UnityEngine;

public class PlayerFEShootSubscriber : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audioSource;
    public AudioClip deathEnemy;
    void Start()
    {
        FE_GetShoot.getShootSound += EnemyDestroySound;
    }


    void EnemyDestroySound()
    {
        audioSource.PlayOneShot(deathEnemy);
    }
    void OnDisable()
    {
        FE_GetShoot.getShootSound -= EnemyDestroySound;
    }
}
