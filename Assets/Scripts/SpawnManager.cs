using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 11.95f; 
    private float spawnPosZ = 23;
    private float startDelay = 2.0f ;
    private float respawnTime = 1.5f ;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating( "SpawnRandomAnimal" , startDelay , respawnTime ); //starting at 2 seconds and repeat every 1.5 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalPrefabs.Length) ;
        Vector3 spawnPos = new Vector3( Random.Range(-spawnRangeX,  spawnRangeX-2 ) , 0 , spawnPosZ );
        Instantiate(animalPrefabs[animalIndex] , spawnPos , animalPrefabs[animalIndex].transform.rotation);
    }
}
