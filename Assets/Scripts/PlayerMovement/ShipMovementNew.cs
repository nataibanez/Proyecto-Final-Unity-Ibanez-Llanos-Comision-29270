using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementNew : MonoBehaviour
{
    public GameObject[] Pillars = new GameObject[12];
    int pillar;
    public float movementCooldownTimer;
    float movementInternalTimer;
    public ReturnPostion poss;
    public AudioSource audioSource;
    public AudioClip shipMovement;

    void Start()
    {
        pillar = 7; //original
        // pillar = 10; //para debug
        movementInternalTimer = movementCooldownTimer;
        transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
    }

    void Update()
    {
        MovementCooldownCountdown();
        ChangePillar();
    }
    void MovementCooldownCountdown()
    {
        movementInternalTimer -= Time.deltaTime;
    }
    void ChangePillar()
    {
            if (Input.GetKey(KeyCode.A) && movementInternalTimer <=0)
            {
                    if(pillar == 12)
                    {
                        pillar = 1;
                    }
                    else
                    {
                        pillar ++;
                    }
                    audioSource.PlayOneShot(shipMovement,0.2f);
                    transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
                    // Las rotaciones funcionan (Z,X,Y)
                    this.transform.Rotate(0,0,-30f,Space.Self);
                    movementInternalTimer = movementCooldownTimer;
            }
            if (Input.GetKey(KeyCode.D) && movementInternalTimer <=0)
            {
                    if(pillar == 1)
                    {
                        pillar = 12;
                    }
                    else   
                    {
                        pillar --;
                    }
                    audioSource.PlayOneShot(shipMovement,0.2f);
                transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);

                this.transform.Rotate(0,0,30f,Space.Self);
                //Debug.Log("Esto está funcionando, letra D");
                movementInternalTimer = movementCooldownTimer;
            }
    }


}

