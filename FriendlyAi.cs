using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyAi : MonoBehaviour
{
    float deathTime;
    float speed = 8;
    

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        deathTime = Random.Range(10, 30);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        deathTime -= Time.deltaTime;
        if (deathTime <= 0)
        {
            speed = 0;
            animator.SetBool("dead", true);
            Destroy(gameObject, 2);
        }
       

    }

    void OnCollisionStay(Collision other)
    {

        // if the player has hit the enemy
        if (other.gameObject.tag == "pistolBullet")
        {
            Debug.Log("friend hit");
            deathTime = 0;
            Destroy(other.gameObject);
        }
        

    }
}
