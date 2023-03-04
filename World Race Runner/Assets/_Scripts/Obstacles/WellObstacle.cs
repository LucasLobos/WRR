using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellObstacle : EntityObstacle
{
    [SerializeField] private float gyroSpeed = 10;
    
    // Si toca el suelo salta.
    
    
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        transform.Rotate(Vector3.forward,gyroSpeed * Time.deltaTime);
    }
    
    
    
    
    
    
}
