using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class MatesSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToSpawn = new List<GameObject>();
    public Vector3 spawnPosition;
    private float _spawnInterval;


    void SpawnRandomObject()
    {
        var index = Random.Range(0, objectsToSpawn.Count);
        Instantiate(objectsToSpawn[index], spawnPosition, Quaternion.identity);
    }

    private void Awake()
    {
        _spawnInterval = Random.Range(1.5f, 5f);
    }

    void Start()
    {
        InvokeRepeating("SpawnRandomObject", 0, _spawnInterval);
    }
}