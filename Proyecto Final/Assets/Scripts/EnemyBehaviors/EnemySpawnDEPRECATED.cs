using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnDEPRECATED : MonoBehaviour
{
    public GameObject[] Pillars = new GameObject[12];
    int pillar;
    public float spawnCooldownTimer;
    float spawnInternalTimer;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public int randomSpawner;

    // Start is called before the first frame update
    void Start()
    {
        pillar = Random.Range(1,12);
        spawnInternalTimer = spawnCooldownTimer;
        transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
        randomSpawner = Random.Range (1,100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RandomSpawner()
    {
            if (randomSpawner <30 && spawnInternalTimer <=0)
            {
                    if(pillar == 12)
                    {
                        pillar = 1;
                    }
                    else
                    {
                        pillar ++;
                    }
                    transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
                    this.transform.Rotate(0,0,-30f,Space.Self);
                    spawnInternalTimer = spawnCooldownTimer;
                    randomSpawner = Random.Range (1,100);
            }
            if (randomSpawner >=30 && randomSpawner <=60  && spawnInternalTimer <=0)
            {
                    if(pillar == 1)
                    {
                        pillar = 12;
                    }
                    else   
                    {
                        pillar --;
                    }
                transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
                this.transform.Rotate(0,0,30f,Space.Self);
                spawnInternalTimer = spawnCooldownTimer;
                randomSpawner = Random.Range (1,100);
            }
            if (randomSpawner >60 && spawnInternalTimer <=0)
            {
                spawnInternalTimer = spawnCooldownTimer;
                randomSpawner = Random.Range (1,100);
            }

    }
}
