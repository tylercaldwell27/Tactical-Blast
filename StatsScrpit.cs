using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class StatsScrpit : MonoBehaviour
{

    public static int scoreValue;
    public static int ammoValue;
    public static int sclipValue;
    public static float healthValue;
    public Text score;
    public Text ammo;
    public Text clips;
    public Text health;

    public PlayerHealth _health;
    // Start is called before the first frame update
    public void Start()
    {
        score.GetComponent<Text>();
        ammo.GetComponent<Text>();
        clips.GetComponent<Text>();
        health.GetComponent<Text>();
        scoreValue = 0;
        ammoValue = 0;
        sclipValue = 0;
        healthValue = _health.health;
}

    // Update is called once per frame
    public void Update()
    {
        
        score.text = "Kills:" + scoreValue;
        health.text = "health:" + healthValue;
        Debug.Log("Score:" + scoreValue);
          


        

    }
}
