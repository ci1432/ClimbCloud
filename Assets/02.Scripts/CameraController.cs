using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cat;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 catPos = cat.transform.position;
        transform.position = new Vector3(transform.position.x, catPos.y, transform.position.z);
    }
}
