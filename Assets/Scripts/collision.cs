﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{
    public PlayerMovement Movement;
    public GameManager GameManger;
    int health = 100;
    void OnCollisionEnter(Collision collisionInfo)
    {

        //We check if the object we collided with as a tag called "Obstacle".
        if (collisionInfo.collider.tag == "oppesiteball")
        {
            health -= 100;
            Debug.Log("noooooooooo");
            if (health == 0)
            {
                Movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("OK it's work");
    }
}
