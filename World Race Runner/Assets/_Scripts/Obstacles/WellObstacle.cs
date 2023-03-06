using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellObstacle : EntityObstacle
{
    [SerializeField] private float gyroSpeed = 10;
    private Rigidbody rb;
    [SerializeField] private float jumpHeight = 300;
    [SerializeField] private bool onFloor = true;

    // Si toca el suelo salta.

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

  

    void Update()
    {
        MoveForward();
        /*transform.Translate(Vector3.left * speed * Time.deltaTime);*/
        transform.Rotate(Vector3.forward, gyroSpeed * Time.deltaTime);
    }

    //private void Jump()
    //{
    //    rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
    //}

    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Well"))
    //    {
    //        Jump();
    //    }
    //}

}
