using System.ComponentModel;
using UnityEngine;

public class PlayerShoot: MonoBehaviour
{
public GameObject playerShoot;
public float shootCooldownTimer;
float shootInternalTimer;
    public AudioSource audioSource;
    public AudioClip shipShoot;

    public void PlayerBulletGenerator()
    {
        Instantiate(playerShoot,transform.position,Quaternion.identity);
        shootInternalTimer = shootCooldownTimer;
    }

    void Start()
    {
        shootInternalTimer = shootCooldownTimer;
    }

    void Update()
    {
        if((Input.GetKey(KeyCode.Space)) && shootInternalTimer <=0)
        {
            audioSource.PlayOneShot(shipShoot,0.15f);
            PlayerBulletGenerator();
        }
        ShootCooldownCountdown();
    }

    void ShootCooldownCountdown()
    {
        shootInternalTimer -= Time.deltaTime;
    }
}