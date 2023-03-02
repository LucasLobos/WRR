using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityObstacle : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int removeLife;
    protected float _currentTime;
    [SerializeField] protected float impactTime = 0.1f;

    void Update()
    {
        MoveForward();
    }

    protected void MoveForward()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }


    protected void OnCollisionStay(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= impactTime && collision.gameObject.TryGetComponent<PlayerMovement>(out var playerMovement))
        {
            _currentTime = 0;
            playerMovement.RemoveLife(removeLife);
        }
    }
}