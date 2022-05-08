// using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_AR : MonoBehaviour
{

public float timelapse=0f; //Cuanto se tarda en empezar a emitir 
public float time = 3.3f; //esto lo uso para que se emita solo una bala dada la velocidad que tiene 
private int seconds; 
private float timegame=110f; 
public float Zpos;
public float Xpos;
public float Ypos;
public float timeErr;

public GameObject[] Pillars = new GameObject[12]; //Esto lo robe de Enemy2RandomSpawn
int pillar; //esto igual




    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {   
 


    
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        timegame -= Time.deltaTime; //Esto por ahora lo estoy usando para que termine el juego

        if (timegame<0)
        {
            Destroy(this);


        }
// Debug.Log("GameTimer()  " +timegame);






        Temporizador();
        if (Temporizador()==0)
           {
        //    CrearBala(); //Original
                   SpawnV2();

        ReiniciarTemporizador();
           }

       }

void ReiniciarTemporizador(){
    timelapse=time;
}



int Temporizador()
    {
    
    timelapse-=Time.deltaTime+Random.Range(-timeErr, timeErr);
    seconds = (int)(timelapse % 60);
    return seconds;   
    }

    void SpawnV2(){

           pillar = Random.Range(1,13);
        // transform.position = new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z);
        Instantiate(prefab, new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z),Quaternion.identity);

        //Debug.Log("pos " + new Vector3(transform.position.x,Pillars[pillar-1].transform.position.y,Pillars[pillar-1].transform.position.z)+ " pillar  "+ pillar);



    }




    void CrearBala()
    {   
        Instantiate(prefab, new Vector3(Random.Range(-Xpos, Xpos), Random.Range(-Ypos, Ypos), Random.Range(-Zpos, Zpos)), Quaternion.identity); //Original
    }

}