using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObjetcts : MonoBehaviour
{

    bool small;
    public float timeToChange;
    bool activateChangeCountDown;
    public int countDownStartValue;
    int timeValue;
    
    void Start()
    {
        small = false;
        countDownStartValue = 2;
        timeValue = countDownStartValue;
        timeToChange = 0.25f;

    }
    void Update()
    {

    }
        void OnTriggerEnter(Collider other)
    {
            Debug.Log(other.gameObject.name);
            if(other.gameObject.name == "Wall")
            {
                countDownTimer();
            }
            
    }

        void OnTriggerExit(Collider other)
        {
            if(other.gameObject.name == "Portal")
            {
                changeSizeSmall();
            }
        }

        void changeSizeSmall()
        {
            if(small == false)
            {
                transform.localScale = transform.localScale/2;
                small = true;
                Debug.Log("SMALL");
            }else
            {
                Invoke("changeToBig",timeToChange);
            }
        }

        void countDownTimer()
        {
            if(timeValue > 0)
            {
                Debug.Log("Timer : " + timeValue);
                timeValue--;
                Invoke("countDownTimer",1.0f);
            }else
            {
                teleport();
                Debug.Log("TELEPORT");
                timeValue = countDownStartValue;
            }
        }
        void teleport()
        {
            transform.position = new Vector3(Random.Range(1.2f,4.0f), 2.5f, Random.Range(-4.0f, 1.5f));
            transform.rotation = new Quaternion (0,Random.Range(0, 180),0,0);
        }

        void changeToBig()
        {
                transform.localScale = transform.localScale*2;
                small = false;
                Debug.Log("BIG");
        }
}
