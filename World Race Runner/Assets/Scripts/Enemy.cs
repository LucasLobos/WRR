using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private bool detected;
    [SerializeField] private LayerMask mask;
    [SerializeField] private  float rayCastDistance = 10f;
    
    [SerializeField] private  Transform eyeView;
    [SerializeField] private Animator animator;
    
    [SerializeField] private float persuitDistance;
    [SerializeField] private Transform characterTransform;
    [SerializeField] private float speed;
    
    [SerializeField] private float viewPlayer = 300;
    private void Update()
    {
        /*
        MoveForward();
        */
        CheckPlayer();
        
        if (detected)
        {
            MoveEnemy();
        }
    }
    
    private void CheckPlayer()
    {
        
        RaycastHit hitInfo = new RaycastHit();
        
        if (Physics.Raycast(eyeView.transform.position, eyeView.forward, out hitInfo, rayCastDistance, mask))
        {
            detected = true;
        }
        else
        {
            detected = false;
        }
    }

    private void MoveEnemy()
    {
        animator.SetTrigger("Persuit");
        
        var vectorPlayer = characterTransform.position - transform.position;
        var distance = vectorPlayer.magnitude;
        
        if (distance > persuitDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                characterTransform.position, Time.deltaTime * speed);
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(eyeView.transform.position,eyeView.forward * rayCastDistance );
        
    }
    
    private void MoveForward()
    {
        transform.position += -transform.right * (speed * Time.deltaTime);
    }
}