using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneObstacle : EntityObstacle
{
    
    [SerializeField] private float jumpHeight;
    private Rigidbody rb;

    

    protected void OnCollisionStay(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= impactTime && collision.gameObject.TryGetComponent<PlayerMovement>(out var playerMovement))
        {
            _currentTime = 0;
            playerMovement.RemoveLife(removeLife);
            StoneExplosion();
        }
    }


    private void StoneExplosion()
    {
        rb.AddForce(Vector3.up * jumpHeight);
    }
}