using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthAndReceiveDamage : MonoBehaviour
{
    public int startingHealth;
    public static int actualHealth;
    public GameObject player;
    public AudioSource audioSource2;
    public AudioClip crashSound;




    // Start is called before the first frame update
    void Start()
    {
        actualHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerDeath();
    }

    // recordar que es ideal poner los sonidos de explosiones de daño acá y no en los enemigos, pues es algo complejo si es que uno destruye la fuente de audio
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy1Shoot")
        {
            actualHealth -= 10;
            //Debug.Log("Te pegaron diez de daño, ahora tienes " + actualHealth + " vida");
            audioSource.PlayOneShot(crashSound);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy2Shoot")
        {
            actualHealth -= 15;
            //Debug.Log("Te pegaron quince de daño, ahora tienes " + actualHealth + " vida");
            audioSource.PlayOneShot(crashSound);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            actualHealth -= 20;
            //Debug.Log("Te pegaron veinte de daño, ahora tienes " + actualHealth + " vida");
            audioSource.PlayOneShot(crashSound);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Enemy3")
        {
            actualHealth -= 30;
            //Debug.Log("Te pegaron treinta de daño, ahora tienes " + actualHealth + " vida");
            audioSource.PlayOneShot(crashSound);
            Destroy(other.gameObject);
        }
    }

    // -----------------------------------------
    //  FELIPE: Voy a crear un Respown 
    // -----------------------------------------

    void PlayerDeath()
    {
        if (actualHealth <= 0)
        {
            gameObject.SetActive(false);
            LifeBarAndScore.playerScore = 0;
            audioSource.PlayOneShot(deathSound);
            Invoke("LiveAgain",5f);
        }
    }

    void LiveAgain()
    {
        gameObject.SetActive(true);
        actualHealth = startingHealth;
        audioSource.PlayOneShot(liveSound);
    }

    // ------- Sonido ----------

    public AudioSource audioSource;
    public AudioClip deathSound;
    public AudioClip liveSound;
}
