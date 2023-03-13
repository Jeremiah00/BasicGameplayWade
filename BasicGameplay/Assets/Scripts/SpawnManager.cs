using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalsRight", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalsLeft", startDelay, spawnInterval);
    }

    // Update is called once per frame
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalsRight()
    {
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRandomAnimalsLeft()
    {
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}
