using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1RandomSpawn : MonoBehaviour
{
    public GameObject[] Pillars = new GameObject[12];
    int pillar;

    // Start is called before the first frame update
    void Start()
    {
        pillar = Random.Range(1,12);
        transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
