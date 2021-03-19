using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMove : MonoBehaviour
{
    Vector3 pos;

    public PlayerHealth hp;
    private float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
    
        if(PlayerHealth.yDoorOpen == true && time > 0) {
            // transform.Translate(Vector3.right * 10f * Time.deltaTime);// the speed of the enemy 
            transform.Translate(Vector3.up * 5f * Time.deltaTime);
            time -= Time.deltaTime;
        }
      
       
    }
   

    }
