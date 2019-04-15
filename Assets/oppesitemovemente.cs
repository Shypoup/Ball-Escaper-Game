using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oppesitemovemente : MonoBehaviour
{
    public Rigidbody rg1;
    public float forwardForce;
    public Rigidbody player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if((rg1.position.z)-(player.position.z) <=10)
        {
            rg1.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
    }
}
