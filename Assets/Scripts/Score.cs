
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
   
    private float score = 0.0f;

    public Text ScoreText;

	
	// Update is called once per frame
	void Update () {
       
        score += Time.deltaTime;
        ScoreText.text = ((int)score).ToString();
	}
}
