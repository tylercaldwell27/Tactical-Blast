using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    //public float runSpeed;
    public FirstPersonController FPC;
    public GunShot setGun;
    public PlayerHealth setHealth;
    static public bool Heavy;
    static public bool heavy;
    static public bool Balance;
    static public bool balance;
    static public bool Fast;
    static public bool fast;
    static public bool Medic;
    static public bool medic;
    static public bool Stealth;
    static public bool stealth;
    void Start()
    {
        Heavy = heavy;
        Balance = balance;
        Fast = fast;
        Medic = medic;
        Stealth = stealth;
    }

    void Update()
    {

        //Player = new
        //checks what scene its in
        if (Input.GetButton("Back") && SceneManager.GetActiveScene().buildIndex == 9){
            SceneManager.LoadScene("Menu");
        }
        if (Input.GetButton("Help") && SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene("help screen");
        }
        if (Input.GetButton("play") && SceneManager.GetActiveScene().buildIndex == 0)
        {//when your on the mainmenu and p is pressed
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);// goes to the next scene
        }
        if (Input.GetButton("play") && SceneManager.GetActiveScene().buildIndex == 7)//when your on the game overmenu and p is pressed
        {
            SceneManager.LoadScene("class select");// goes to the next scene
        }
        if (Input.GetButton("play") && SceneManager.GetActiveScene().buildIndex == 8)//when your on the game overmenu and p is pressed
        {
            SceneManager.LoadScene("class select");// goes to the next scene
        }
        if (Input.GetButton("Heavy") && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Tuturial");// goes to the next scene
            heavy = true;
            setHealth.health = 200;
            balance = false;
            fast = false;
            medic = false;
            stealth = false;

        }
        else if (Input.GetButton("Balance") && SceneManager.GetActiveScene().buildIndex == 1)
        {
           
             SceneManager.LoadScene("Tuturial");// goes to the next scene
            balance = true;
            setHealth.health = 150;
            heavy = false;
            fast = false;
            medic = false;
            stealth = false;
        }
        else if (Input.GetButton("Fast") && SceneManager.GetActiveScene().buildIndex == 1)
        {

            SceneManager.LoadScene("Tuturial");// goes to the next scene
            fast = true;
            setHealth.health = 100;
            heavy = false;
            balance = false;
            medic = false;
            stealth = false;

        }

        else if (Input.GetButton("Medic") && SceneManager.GetActiveScene().buildIndex == 1)
        {

            SceneManager.LoadScene("Tuturial");// goes to the next scene
            medic = true;
            setHealth.health = 125;
            heavy = false;
            balance = false;
            fast = false;
            stealth = false;

        }
        else if (Input.GetButton("Stealth") && SceneManager.GetActiveScene().buildIndex == 1)
        {

            SceneManager.LoadScene("Tuturial");// goes to the next scene
            stealth = true;
            medic = false;
            setHealth.health = 50;
            heavy = false;
            balance = false;
            fast = false;

        }
    }
       
      
    
    
}
