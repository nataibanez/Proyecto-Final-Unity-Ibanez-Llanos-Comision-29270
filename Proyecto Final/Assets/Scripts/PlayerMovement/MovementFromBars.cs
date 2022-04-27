using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFromBars : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Nave" && Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Movimiento Correcto");
        }
    }
}