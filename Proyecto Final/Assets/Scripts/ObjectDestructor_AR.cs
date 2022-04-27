using UnityEngine;

public class ObjectDestructor_AR : MonoBehaviour
{

    public float destroyObjectTimer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,destroyObjectTimer);
    }
}
