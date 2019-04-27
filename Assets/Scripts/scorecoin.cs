using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scorecoin : MonoBehaviour
{

    public Transform player;
    public Text scoretext;
    // Update s called once per frame

    void Update()
    {

        scoretext.text = player.position.z.ToString();
    }
}
