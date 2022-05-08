using System;
using UnityEngine;

public class FE_GetShoot : MonoBehaviour
{
    public static event Action getShootSound;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerShoot")
        {
            getShootSound?.Invoke();
            LifeBarAndScore.playerScore++;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }    
    }
}
