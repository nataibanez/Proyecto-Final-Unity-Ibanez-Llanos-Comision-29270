using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColisionPilar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Pillar6")
        {
            Debug.Log("Está tocando el pilar de abajo");
        }
    }

}
