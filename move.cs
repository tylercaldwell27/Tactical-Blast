using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;
using UnityStandardAssets.Characters.FirstPerson;
public class move : MonoBehaviour
{
    public Animator animator;
    float speed = 0;
    bool jump = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {


            speed = 1;
            animator.SetFloat("speed", speed);
        }
      
        else
        {
            speed = 0;
            animator.SetFloat("speed", speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {

            jump = true;
            animator.SetBool("jump", true);
        }
        else
        {
            jump = false;
            animator.SetBool("jump", false);
        }
        if (Input.GetButton("Fire1"))
        {

           // jump = true;
            animator.SetBool("shoot", true);
        }
        else
        {
           // jump = false;
            animator.SetBool("shoot", false);
        }
    }
}
