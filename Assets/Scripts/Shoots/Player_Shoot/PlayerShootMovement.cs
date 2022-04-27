using UnityEngine;

public class PlayerShootMovement : MonoBehaviour
{
    public float speed = 1;
    float shootDirection = -1f;
    public int damage = 10;

    void Update()
    {
        {
            transform. position += new Vector3(shootDirection,0,0) * speed *Time.deltaTime;
        }
        
    }
}