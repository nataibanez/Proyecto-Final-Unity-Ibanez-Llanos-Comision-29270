using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum EnemyType{
    One,
    Two,
    Three
}
    public Transform GoToPlayer;
    public Transform LookPlayer;
    public EnemyType enemyType;

    float EnemyDistance(){
        float distance = Vector3.Distance(LookPlayer.position, transform.position);
        return distance;
    }
        void LookThePlayer()
    {
        Quaternion rot = Quaternion.LookRotation(LookPlayer.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, rot , Time.deltaTime);
    }
        void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position,GoToPlayer.position, Time.deltaTime);
    }

    void Update()
    {
        if(enemyType == EnemyType.One){
            LookThePlayer();
        }
        if(enemyType == EnemyType.Two){
            LookThePlayer();
            if(EnemyDistance() >= 2)
            {
                FollowPlayer();
            }
        }

    }
}
