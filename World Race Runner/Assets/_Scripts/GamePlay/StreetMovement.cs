
using UnityEngine;

public class StreetMovement : MonoBehaviour
{


    [SerializeField] private float speed;
    [SerializeField] private float speedTerrain;


    private void Update()
    {
        MoveForward();
        MoveForwardTarrain();
    }


    private void MoveForward()
    {
        transform.position += -transform.right * (speed * Time.deltaTime);
    }
    
    private void MoveForwardTarrain()
    {
        transform.position += -transform.forward * (speedTerrain * Time.deltaTime);
    }
}

