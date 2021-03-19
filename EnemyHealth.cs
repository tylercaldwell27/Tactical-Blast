using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    private NavMeshAgent navCompnent;
    public float enemyHealth = 60f;// sets the enemy health to 100
    Animator animator;


    void Start()
    {
        navCompnent = this.gameObject.GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    //method for get rid of health
    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;//sets the enemy health to enemy health subtract decutHealth
        //Debug.Log(enemyHealth);

        // checks if the health is less than or equal too zero
        if (enemyHealth <= 0)
        {
            navCompnent.speed = 0;
            animator.SetBool("dead", true);
            gameObject.tag = "dead";
            EnemyDead();//calls the enemy dead method
        }

    }
    // enemy dead method
    void EnemyDead()
    {
        
        Destroy(gameObject, 2);// gets rid of the game object
    }

    void OnCollisionStay(Collision other)
    {

        // if the player has hit the enemy
        if (other.gameObject.tag == "Player")
        {
           // animator.SetBool("hit", true);
        }
        else {
           // animator.SetBool("hit", false);
        }

    }
}
