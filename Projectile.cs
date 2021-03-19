using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile: MonoBehaviour {

    GameObject prefab;
	void Start () {
      //  prefab = Resources.Load("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
    
            Destroy(gameObject,2);
        
	}
}
