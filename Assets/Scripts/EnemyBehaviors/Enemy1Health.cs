using UnityEngine;

public class Enemy1Health : MonoBehaviour
{
public int startingHealth = 30;
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
            Destroy(other.gameObject);
            actualHealth -= 10;
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
