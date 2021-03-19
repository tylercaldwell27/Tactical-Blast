using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerCollision : MonoBehaviour {

    public float health = 100f;// sets the enemy health to 100
    void OnCollisionStay (Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
           int damagePlayer = 10;
            health = health - damagePlayer;
            Debug.Log(health);
            if (health <= 0)
            {
                Debug.Log("GameOver");
            }
        }
    }
}
