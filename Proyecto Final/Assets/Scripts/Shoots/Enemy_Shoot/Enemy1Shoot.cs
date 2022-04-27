using System.Security.Cryptography;
using System.ComponentModel;
using UnityEngine;

public class Enemy1Shoot: MonoBehaviour
{
public GameObject shoot;


    public float minEnemyRandom = 1f;
    public float maxEnemyRandom = 3f;
    float shootRandomTime;


    public void EnemyBulletGenerator()
    {
        Instantiate(shoot,transform.position,Quaternion.identity);
    }

    void Start()
    {
        NewRandom();
    }

    void Update()
    {
        if(shootRandomTime <= 0)
        {
            EnemyBulletGenerator();
            NewRandom();
        }else
        {
            Timer();
        }
    }

    void Timer()
    {
        shootRandomTime -= Time.deltaTime;
    }   

    void NewRandom()
    {
        shootRandomTime = Random.Range(minEnemyRandom,maxEnemyRandom);
    }
    
}
