
using UnityEngine;


public class CowObstacule : EntityObstacle
{

    [SerializeField] private float gyroSpeed = 10;
    
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward,gyroSpeed * Time.deltaTime);
    }

}
