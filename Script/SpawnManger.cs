using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] zombiePrefabs;
    private Animator animZombie;
    private float startDelay = 4;
    private float spawnInterval = 5f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        animZombie = GetComponent<Animator>();
        InvokeRepeating("SpawnRandomZombie",startDelay,spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomZombie()
     {
            //Randomly Generates Zombie Index and Spawn
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ);
            Vector3 spawnPos1 = new Vector3(-90,2.94f,23);
            Vector3 spawnPos2 = new Vector3(-90,2.94f,26);
            Vector3 spawnPos3 = new Vector3(-90,2.94f,29);
            

            //random range is use for spawn randomly zombie
            //we use zero in bracket its index of an Array
            //using length assign to the zombie Prefab.. lenth is of an array 
           int zombieIndex1 = Random.Range(0, zombiePrefabs.Length); 
           int zombieIndex2 = Random.Range(0, zombiePrefabs.Length);
           int zombieIndex3 = Random.Range(0, zombiePrefabs.Length);  
           //here we spawn Zombie
           Instantiate(zombiePrefabs[zombieIndex1],spawnPos1,zombiePrefabs[zombieIndex1].transform.rotation);
           Instantiate(zombiePrefabs[zombieIndex2],spawnPos2,zombiePrefabs[zombieIndex2].transform.rotation);
           Instantiate(zombiePrefabs[zombieIndex3],spawnPos3,zombiePrefabs[zombieIndex3].transform.rotation);
           
           
     }
}
