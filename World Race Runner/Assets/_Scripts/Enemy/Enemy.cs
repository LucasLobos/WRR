using System.Collections.Generic;

using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private bool detected;
    [SerializeField] private LayerMask mask;
    [SerializeField] private  float rayCastDistance = 12f;
    
    [SerializeField] private  Transform eyeView;
    [SerializeField] private Animator animator;
    
    [SerializeField] private float persuitDistance;
    [SerializeField] private Transform characterTransform;
    [SerializeField] private float speed;
    [SerializeField] private float speedToLook;
    /*
    [SerializeField] private float viewPlayer = 300;
    */
    private bool _persuit;

    private void Start()
    {
        _persuit = false;
    }

    private void Update()
    {
        CheckPlayer();

        if (detected)
        {
            _persuit = true;
            
        } else if (_persuit == true)
        {
            MoveEnemy();
            rayCastDistance = 4f;
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

        Quaternion newRotations = Quaternion.LookRotation(characterTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotations, speedToLook * Time.deltaTime);

    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(eyeView.transform.position,eyeView.forward * rayCastDistance );
        
    }

  
}