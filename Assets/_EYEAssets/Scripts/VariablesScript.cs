using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesScript : MonoBehaviour
{
    public string myName = "Eric";
    public int age = 51;
    public float speed = 3.01f;
    public int health = 100;
    public int score = 42;
    public int keys = 0;
    public bool areKeysCollected;
    public int ammoCount = 23;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            keys++;
            if(keys >= 3)
            {
                areKeysCollected = true;    
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player Name: " + myName);
            Debug.Log("Age: " + age);
            Debug.Log("Speed: " + speed);
            Debug.Log("Health: " + health);
            Debug.Log("Score: " + score);
            Debug.Log("Keys Collected: " + keys);
            Debug.Log("All Keys Collected: " + areKeysCollected);
            Debug.Log("Ammo Count: " + ammoCount);




        }
    }
}
