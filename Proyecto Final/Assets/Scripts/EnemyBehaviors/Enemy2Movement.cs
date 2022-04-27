using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Movement : MonoBehaviour
{
    public GameObject[] Pillars = new GameObject[12];
    int pillar;
    public float movementCooldownTimer;
    float movementInternalTimer;
    public ReturnPostion poss;
    public int randomMovementDirection;

    void Start()
    {
        pillar = Random.Range(1,12);
        movementInternalTimer = movementCooldownTimer;
        transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
        //transform.position = new Vector3(transform.position.x,Pillars[pillar].transform.position.y,Pillars[pillar].transform.position.z);
        //this.transform.Rotate(0,0,-30f,Space.Self);
        randomMovementDirection = Random.Range (1,100);
    }

    void Update()
    {
        MovementCooldownCountdown();
        RandomChangePillar();
        //RandomMovementGenerator();
    }
    void MovementCooldownCountdown()
    {
        movementInternalTimer -= Time.deltaTime;
    }
    void RandomChangePillar()
    {
            if (randomMovementDirection <30 && movementInternalTimer <=0)
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
                    movementInternalTimer = movementCooldownTimer;
                    randomMovementDirection = Random.Range (1,100);
            }
            if (randomMovementDirection >=30 && randomMovementDirection <=60  && movementInternalTimer <=0)
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
                movementInternalTimer = movementCooldownTimer;
                randomMovementDirection = Random.Range (1,100);
            }
            if (randomMovementDirection >60 && movementInternalTimer <=0)
            {
                movementInternalTimer = movementCooldownTimer;
                randomMovementDirection = Random.Range (1,100);
            }
            
    }
}
