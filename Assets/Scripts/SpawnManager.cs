using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float _spawnRangeX = 12;
    private float _spawnRangeZ = 20;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.4f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0f, _spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}