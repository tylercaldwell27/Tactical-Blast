using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolEnemy : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;
   public PlayerHealth hp;
    public GunShot player;
    public EnemyHealth enemyHp;
    public AudioSource gunSound;
    // Start is called before the first frame update
    void Start()
    {
        fireRate = 3f;
        nextFire = Time.time;

    }

    // Update is called once per frame
    void Update()

    { 
        if(player.hide == false) { 
        if (Time.time > nextFire)
        {
            gunSound.Play();
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;

        }
            if (enemyHp.enemyHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        if(player.hide == true)
        {

        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            hp.health = hp.health - 10;
            hp.SetHealthText();
            Debug.Log("you got shot");
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Ai")
        {
          
            Debug.Log("they got shot");
            Destroy(other.gameObject);
        }
    }
}
