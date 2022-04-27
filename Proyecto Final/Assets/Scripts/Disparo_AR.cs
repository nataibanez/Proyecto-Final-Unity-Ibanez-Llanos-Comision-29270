// using System.Diagnostics;
// using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo_AR : MonoBehaviour
{

public int damageLife = 150;
public float rotX =0;
public float rotY =0;
public float rotZ =0;
public float velocity ;
public Vector3 direction;
public float Scale;
// public float objectScaleNumber=2f;

    // Start is called before the first frame update
    void Start()
    {
             ScaleObject(Scale);

               // Debug.Log("Tu vida es "+ Heal(healLife,life));
               // Debug.Log("Tu vida es "+ Damage(damageLife,life));


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement(direction,velocity);
        RotationObj();
    //  if (Input.GetKeyDown(KeyCode.Space)){
        
    //     ScaleObject(2); //El tamano del objeto aumenta al doble

    //  }

    }


Vector3 Movement( Vector3 dir, float vel){

    float lengthDir = dir.magnitude;
    Vector3 NormDir = dir/lengthDir;
return  transform.position += NormDir*vel*Time.deltaTime;
}

void RotationObj(){

        transform.Rotate(new Vector3(Random.Range(-rotX, rotX), rotY, rotZ) * Time.deltaTime);

}



Vector3 ScaleObject(float objectScale)
{
Vector3 newScale = new Vector3(objectScale,objectScale,objectScale);
return  transform.localScale = newScale;



}









}
