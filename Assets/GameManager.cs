
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public void EndGame()
    {
        Debug.Log("Game over");
    }
}
/*

public PlayerMovement movement;     //Aa reference to our PlayerMovement Script
    public GameManager gameManager;



    //This func. runs when we hit another object.
    //We get info. about the collision and call it "collisionInfo"
    void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with as a tag called "Obstacle".
        if (collisionInfo.colider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }


*/