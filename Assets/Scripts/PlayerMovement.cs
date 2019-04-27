
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
	private CharacterController controller;
	private float speed = 5.0f;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	
	void Update () {
		controller.Move(Vector3.forward * speed * Time.deltaTime);


		if (Input.GetKey(forwardButton))
		{
			speed += speed * Time.deltaTime;
		}
		if (Input.GetKey(slowButton))
		{
			speed -= speed * Time.deltaTime;
		}

		if (Input.GetKey(rightButton))
		{
			rg.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}


		if (Input.GetKey(leftButton))
		{
			rg.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rg.position.y <= -1F)
		{
			FindObjectOfType<GameManager>().EndGame();
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


