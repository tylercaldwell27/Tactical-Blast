using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour {


    


    public float health;// sets the enemy health to 100

    //text
    public Text healthText;
    public Text GameOver;
    
    public bool playerHit = false;
    public bool door;
    public bool bossFight = false;
    public  int damagePlayer;


   public float AttackSpeed;//rate of enemy attack speed
    float NextHit = 0;

    public MainMenu Menu;
    public GunShot gun;
    
    
    float normalDam;
    float boostDam;
    static public bool YDoorOpen = false;
    static public bool yDoorOpen = false;
    float t;

    public AudioSource healthPickUp;
    public AudioSource playerHitSound;
    public AudioSource damageSound;
    Animator anim;

    void Start()
    {
        anim= GetComponent<Animator>();
        YDoorOpen = false;
        yDoorOpen = false;
        if (MainMenu.heavy == true)
        {
            health = 200;
        }
        if (MainMenu.balance == true)
        {
            health = 150;

        }
        if (MainMenu.fast == true)
        {
            health = 100;
        }
        if (MainMenu.medic == true)
        {
            health = 125;
        }
        door = false;
        RemoveGameOverText();// calls the method to set the health text
        SetHealthText();
        YDoorOpen = yDoorOpen;
    }

    public void Update()
    {
      
       if(gun.kills >= 50 && SceneManager.GetActiveScene().buildIndex == 2)
        {
            yDoorOpen = true;
        }
       
    }
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "door")
        {
            Debug.Log("time to die");
            bossFight = true;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "floor")
        {
            Debug.Log("byebye");
            Destroy(GameObject.FindWithTag("gun"));
        }

        // if the player has hit the enemy
        if (other.gameObject.tag == "Enemy")
        {
            if (Time.time > NextHit)
            {
                playerHitSound.Play();
                NextHit = Time.time + AttackSpeed;
                 //damagePlayer = 10;// the ammont of damge the enemy does to the player
                health = health - 10.0f;//subtracts the amoutn of damage done from the players health
               // Debug.Log(health);// prints the remaining health to the screen.
                SetHealthText();// calls the  text method to update the text
                Debug.Log(health);
            }
        }

        if (other.gameObject.tag == "Health")
        {
            Debug.Log("health picked");
                healthSound();
                health = health + 10;//subtracts the amoutn of damage done from the players health
              //  Debug.Log(health);// prints the remaining health to the screen.
               SetHealthText();// calls the  text method to update the text
               Destroy(other.gameObject);
            Debug.Log(health);

        }

        if (other.gameObject.tag == "DamageBoost")
        {
            damageSound.Play();
            gun.damageEnemy += 1000;
            Destroy(other.gameObject);

        }


        if (other.gameObject.tag == "YellowKey")
        {

            yDoorOpen = true;
            Destroy(other.gameObject);
        }

            if (other.gameObject.tag == "finish")
        {
            Debug.Log("done");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       


      
            if (other.gameObject.tag == "pistolBullet")
            {
                health = health - 10;
                SetHealthText();
                Debug.Log("you got shot");
                Destroy(other.gameObject);
            }
        


        //checks to see when the player has zero health
        if (health <= 0)
        {
            transform.Translate(Vector3.forward * 0 * Time.deltaTime);// the speed of the enemy
            health = 0;// sets health to zero to keep it there
            SetHealthText();// calls the  text method to update the text
                            // Destroy(gameObject);
                            
            SceneManager.LoadScene("Game Over");

            SetGameOverText();
        }


    }



       public void SetHealthText()
    {
        healthText.text = "Health: " + health.ToString();// updates the current health on the screen when called
    }



    void SetGameOverText()
    {
        GameOver.text = "GameOver ";
    }
    void RemoveGameOverText()
    {
        GameOver.text = "";
    }
    void healthSound ()
    {
        healthPickUp.Play();

    }
   
}
