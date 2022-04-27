using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 15;

void Move()
{
    float hor = Input.GetAxis("Horizontal");
    float ver = Input.GetAxis("Vertical");
    transform.Translate(-ver*Time.deltaTime*speed,0,0);
    transform.Rotate(0,hor*Time.deltaTime*speed*20,0);
}

    void Update()
    {
        Move();
    }

}
