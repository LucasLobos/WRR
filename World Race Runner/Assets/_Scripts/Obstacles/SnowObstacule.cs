
using UnityEngine;

public class SnowObstacule : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int removeLife;
    protected float _currentTime;
    [SerializeField] protected float impactTime = 0.2f;

    private void MoveSnowObstacle()
    {
        Vector3 posicionActual = transform.position;
        posicionActual.z -= (speed * Time.deltaTime);
        transform.position = posicionActual;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= impactTime && collision.gameObject.TryGetComponent<PlayerStats>(out var player))
        {
            _currentTime = 0;
            player.RemoveLife(removeLife);
        }
    }

    private void Update()
    {
        
        MoveSnowObstacle();
    }
}
