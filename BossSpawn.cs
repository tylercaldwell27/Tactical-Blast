using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = true;
    public float spawnTime;
    public float spawnDelay;
    float time = 4;
   public PlayerHealth player;
 
    // Use this for initialization
    void Start()
    {
       stopSpawning = true;
           InvokeRepeating("SpawnObject", spawnTime, spawnDelay);//setsup the spawner
    }

    void Update()
    {
        Debug.Log(player.bossFight);
        if(player.bossFight == true)
        {
            if(time > 0)
            {
                time -= Time.deltaTime;
            }
            if (time <= 0)
            {
                stopSpawning = false;
                SpawnObject();
                time = 4;
            }
          
        }
    }
    public void SpawnObject()
    {

        Instantiate(spawnee, transform.position, transform.rotation);//spawns the object in  if stopSpawning is false
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");//stops spawning
        }
    }
}
