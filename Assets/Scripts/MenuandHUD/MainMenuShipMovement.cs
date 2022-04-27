using UnityEngine;

public class MainMenuShipMovement : MonoBehaviour
{
    public float menuShipSpeed;
    float menuShipDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(menuShipDirection,0,0) * menuShipSpeed *Time.deltaTime;
    }
}
