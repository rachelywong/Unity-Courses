using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Create an array of the animal prefabs to spawn them randomly when 's' is pressed
    public GameObject[] animalPrefabs;

    // use this as animal index in array
    //public int animalIndex;

    // Randomize the spawn location
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    // Invoke repeating times
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Invoke repeating, spawn animals at timed intervals
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // "method" to invoke, time to start repeat, time interval
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        // now just call SpawnRandomAnimal function
        //    SpawnRandomAnimal();
        //}
    }

    // Custom function to spawn animals automatically
    void SpawnRandomAnimal() // every time we call the function we will create a new animal
    {
        // Randomize spawn location
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); // New local variable spawnPos

        // Randomize animal index
        int animalIndex = Random.Range(0, animalPrefabs.Length); // Get a random animal index from length of animal prefabs
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
