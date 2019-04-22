
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            restart();
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
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