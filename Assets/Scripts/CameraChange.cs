using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
public GameObject Camera1;
public GameObject Camera2;

    // Start is called before the first frame update
    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            CameraToggle();
        }
    }

    void CameraToggle()
    {
        if(Camera1.activeInHierarchy)
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);
        }
        else    
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);
        }
    }
}