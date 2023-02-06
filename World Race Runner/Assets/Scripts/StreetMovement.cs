using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetMovement : MonoBehaviour
{


    [SerializeField] private float speed;


    private void Update()
    {
        MoveForward();
    }


    private void MoveForward()
    {
        transform.position += -transform.right * (speed * Time.deltaTime);
    }
}

