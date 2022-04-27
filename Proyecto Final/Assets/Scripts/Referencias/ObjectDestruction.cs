using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestruction : MonoBehaviour
{

// Time to destroy object 
public float destroyTime = 5f;

    void timer()
    {
        destroyTime -= Time.deltaTime;
    }
    void destroyObject()
    {
        if (destroyTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer();
        destroyObject();
    }
    

}
