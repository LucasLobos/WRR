
using UnityEngine;


public class ObstacleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    public Vector3 spawnPosition;
    private float _spawnInterval;
    private float _startDelay = 2;
    private float _timeToDestroyObstacle = 5f;
    void SpawnRandomObject()
    {
        var obstaclePrefab = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];
        var obstacleInstance = Instantiate(obstaclePrefab, spawnPosition, Quaternion.Euler(0,180,0));
        Destroy(obstacleInstance,_timeToDestroyObstacle);
    }
    
    private void Awake()
    {
        _spawnInterval = Random.Range(2f, 4f);
    }

    void Start()
    {
        InvokeRepeating("SpawnRandomObject", _startDelay, _spawnInterval);
    }
}

