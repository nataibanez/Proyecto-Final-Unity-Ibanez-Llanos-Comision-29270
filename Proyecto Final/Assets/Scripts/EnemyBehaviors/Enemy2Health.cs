using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
public int startingHealth = 20;
int actualHealth;
    // Start is called before the first frame update
    void Start()
    {
        actualHealth = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerShoot")
        {
            actualHealth -= 10;
            Destroy(other.gameObject);
            HealthCheck();
        }
    }

    void HealthCheck()
    {
        if (actualHealth <= 0)
            {
                
                Destroy(this.gameObject);
            }
    }
}
