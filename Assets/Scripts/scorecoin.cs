using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorecoin : MonoBehaviour
{

    public Transform player;
    private float score = 0.0f;

    public Text scorecoins;
    // Update s called once per frame

    void Update()
    {

       /* scoretext.text = player.position.z.ToString();*/
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("coins" ))
        {
            score += 1;
            Destroy(other.gameObject);
            scorecoins.text = ((int)score).ToString();
        }


    }
}
