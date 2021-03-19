using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class AiMovement : MonoBehaviour
{
    Transform target;
    public Transform myTransform;
     public GunShot player;
    public float distanceAway;
    private NavMeshAgent navCompnent;
    public float rotateSpeed = 3.0F;
    Animator animator;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navCompnent = this.gameObject.GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        if(player.hide == true)
        {
            target = GameObject.FindGameObjectWithTag("Health").transform;
        }
        if (player.hide == false)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        // float dist = Vector3.Distance(target.position, transform.position);
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * rotateSpeed, 0.0f);
        Vector3 targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.LookAt(targetPos);
        navCompnent.SetDestination(target.position);
       
        distanceAway = target.position.x - transform.position.x;

        if (distanceAway < 4.0 && distanceAway > -4.0)
        {
           // Debug.Log("you got hit");
           // Debug.Log(distanceAway);
            animator.SetBool("hit", true);
        }
        else
        {
            animator.SetBool("hit", false);
        }


    }

   
 
    }
