
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rg;
	public float forwardForce;
	public float sidewaysForce;
	public KeyCode leftButton, rightButton, forwardButton,slowButton;
    public Text scoreText;
    public int score = 0;
    

	void Start () {
		
	}
	
	
	void Update () {
		rg.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey(forwardButton))
        {
            forwardForce += sidewaysForce * Time.deltaTime;
        }
        if (Input.GetKey(slowButton))
        {
            forwardForce -= sidewaysForce * Time.deltaTime;
        }

        if (Input.GetKey(rightButton))
		{
			rg.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}


        if (Input.GetKey(leftButton))
		{
			rg.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        if (rg.position.y <= -5)
        {
            restart();
        }





	}

    public void OnTriggerEnter(Collider other)
    {
        
            Destroy(other.gameObject);
            
       
        
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Fallen");
    }
}


