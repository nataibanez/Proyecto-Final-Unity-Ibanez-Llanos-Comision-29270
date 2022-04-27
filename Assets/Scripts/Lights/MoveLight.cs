using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLight : MonoBehaviour
{
    public enum colors{red,green,yellow,pink};
    public colors selectColor;
    public float speed = 100;
    float Direction = 1f;
    Vector3 initialPosition;
    public float CooldownTimer;
    float InternalTimer;
    void Start()
    {
        initialPosition = this.transform.position;
        InternalTimer = Random.Range(4f,6f);
        speed = Random.Range(80f,100f);
        //Debug.Log("Posicion Inicial: "+initialPosition);
    }
    void Update()
    {
        Forward();
        CountDown();
        //Debug.Log("Avanza");
        //Debug.Log(InternalTimer);
        if(InternalTimer <= 0)
        {
            Return();
        }
    }

    void Forward()
    {
        transform.position += new Vector3(Direction,0,0) * speed *Time.deltaTime;
    }
        void Return()
    {
        transform.position = initialPosition;
        //InternalTimer = CooldownTimer;
        chooseColor(selectColor);
    }

    void CountDown()
    {
        InternalTimer -= Time.deltaTime;
    }

    void chooseColor(colors c)
    {
        switch (c)
        {
            case colors.red:
            InternalTimer = Random.Range(3.5f,4f);
            speed = Random.Range(80f,100f);
            break;
            case colors.yellow:
            InternalTimer = Random.Range(5.5f,6.5f);
            speed = Random.Range(90f,100f);
            break;
            case colors.green:
            InternalTimer = Random.Range(5f,6f);
            speed = Random.Range(70f,100f);
            break;
            case colors.pink:
            InternalTimer = Random.Range(3f,4f);
            speed = Random.Range(60f,100f);
            break;
        }
    }
}
