
using UnityEngine;

public class EntityObstacle : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int removeLife;
    protected float _currentTime;
    [SerializeField] protected float impactTime = 0.2f;

    void Update()
    {
        MoveForward();
    }

  /*private void Start()
    {
        Destroy(gameObject,5.00f);
    }*/

    protected void MoveForward()
    {
        transform.position += transform.forward * (speed * Time.deltaTime);
    }

  
    
    protected void OnCollisionEnter(Collision collision)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= impactTime && collision.gameObject.TryGetComponent<PlayerStats>(out var player))
        {
            _currentTime = 0;
            player.RemoveLife(removeLife);
            Debug.Log("Kill Player");
        }
    }
}