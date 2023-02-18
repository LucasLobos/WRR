using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] car;
    public Vector3 spawnPosition;
    private float _spawnInterval;

    void SpawnRandomObject()
    {
        var index = Random.Range(0, car.Length);
        Instantiate(car[index], spawnPosition, Quaternion.Euler(0,180,0));
    }
    
    private void Awake()
    {
        _spawnInterval = Random.Range(2f, 10f);
    }

    void Start()
    {
        InvokeRepeating("SpawnRandomObject", 0, _spawnInterval);
    }
}
