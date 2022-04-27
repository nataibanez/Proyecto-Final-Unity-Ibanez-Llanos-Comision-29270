using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPostion : MonoBehaviour
{
    // Start is called before the first frame update
    public float x;
    public float y;
    public float z;

    void Update()
    {

    }

    public float ReturnX()
    {
        x = transform.position.x;
        Debug.Log("Posicion X es: "+x);
        return x;
    }
    public float ReturnY()
    {
        y = transform.position.y;
        Debug.Log("Posicion Y es: "+y);
        return y;
    }
    public float ReturnZ()
    {
        z = transform.position.z;
        Debug.Log("Posicion Z es: "+z);
        return z;
    }
    
}
