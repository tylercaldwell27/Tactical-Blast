using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


	// Use this for initialization
	void Start () {
       
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);//setsup the spawner
	}
	
	public void SpawnObject(){

        Instantiate(spawnee, transform.position, transform.rotation);//spawns the object in  if stopSpawning is false
        if (stopSpawning){
            CancelInvoke("SpawnObject");//stops spawning
        }
    }
}
