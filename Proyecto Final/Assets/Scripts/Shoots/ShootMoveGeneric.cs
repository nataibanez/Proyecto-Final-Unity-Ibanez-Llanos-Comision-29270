    
using UnityEngine;

public class ShootMoveGeneric : MonoBehaviour
{
    public float speed = 1;
    float shootDirection = 1f;
    public int damage = 10;

    void Update()
    {
        if(gameObject.tag == "Enemy")
        {
            transform. position += new Vector3(shootDirection,0,0) * speed *Time.deltaTime;
        }
        else
        {
            transform. position += new Vector3(-shootDirection,0,0) * speed *Time.deltaTime;
        }
        
    }
}