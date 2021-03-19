using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGun : MonoBehaviour
{
    float moveSpeed = 100;
    Rigidbody rb;

   public PlayerHealth target;
     EnemyHealth Enemyhealth;
    float health; 
    Vector3 Direction;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindObjectOfType<PlayerHealth>();
       
        Direction = (target.transform.position - transform.position).normalized * moveSpeed;
      
        rb.velocity = new Vector3(Direction.x, Direction.y, Direction.z);
      //  Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.name.Equals("Player")){
            Debug.Log("you got hit");
            Destroy(gameObject);

        }
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        transform.LookAt(targetPos);
       
    }
}
