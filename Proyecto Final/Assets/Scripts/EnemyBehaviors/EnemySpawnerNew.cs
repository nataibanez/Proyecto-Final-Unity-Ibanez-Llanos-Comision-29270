using UnityEngine;

public class EnemySpawnerNew : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    // Start is called before the first frame update
    
    void Start()
    {
        SpawnWave1();
    }

    // Update is called once per frame
    void Update()
    {
                SpawnWave1();

    }

    void SpawnWave1()
    {
        Instantiate(Enemy1);
        Instantiate(Enemy1);
        // Instantiate(Enemy3);
    }
}
