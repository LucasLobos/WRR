using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RemoveLife : MonoBehaviour
{
    [SerializeField] private int removeLife;
    private float _currentTime;
    [SerializeField] private float impactTime = 0.1f;
    private void OnCollisionStay(Collision collision)
    {
        _currentTime += Time.deltaTime;
        
        if (_currentTime >= impactTime && collision.gameObject.TryGetComponent<PlayerMovement>(out var playerMovement))
        {
            _currentTime = 0;
            playerMovement.RemoveLife(removeLife);
        }
    }
}