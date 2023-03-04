using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float speed;


    private void Update()
    {
        MoveForward();
    }


    private void MoveForward()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }
}
