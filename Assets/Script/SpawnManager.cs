using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.S))
      
      {  
        int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
        UnityEngine.Vector3 spawnPos = new UnityEngine.Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

      }  
    }
}
