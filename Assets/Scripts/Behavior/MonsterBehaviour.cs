﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLIDING");
        Debug.Log(other.name);
        if (other.name == "Player")
        {
            Debug.Log("You die.");
            //Time.timeScale = 0f;
            Menu.isDead = true;
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
