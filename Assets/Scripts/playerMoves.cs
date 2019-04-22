
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMoves : MonoBehaviour {
    private Vector3 moveVector;
    private float speed = 10.0f;
    private CharacterController controller;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;

    private float animationDuration = 3.0f;

    void Start () {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time < animationDuration)
        {
            controller.Move(Vector3.forward * speed * Time.deltaTime);
            return;
        }


        moveVector = Vector3.zero;
        if (controller.isGrounded)
        {
            verticalVelocity = -0.5f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
        // x - left and right
        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        // y  - up and down 
        moveVector.y = verticalVelocity;
        // z - forward and backward 
        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);

        if (moveVector.y <= -1F)
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

