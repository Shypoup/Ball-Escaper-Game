using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundManager : MonoBehaviour
{

    public GameObject[] lands;

    public Transform playerTransform;
    private float spawnZ = 0.0f;
    private float tileLengh = 144.1f;
    private int amnTileOnScreen = 2;



	// Use this for initialization
	void Start ()
    {
        playerTransform = GameObject.FindGameObjectWithTag("player").transform;

        for (int i = 0; i < amnTileOnScreen; i++)
        {
            SpawnTile();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerTransform.position.z > (spawnZ - amnTileOnScreen * tileLengh))
        {
            SpawnTile();
        }

    }




    private void SpawnTile(int prefabIndex = 0 )
    {
        GameObject go;
        go = Instantiate(lands[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLengh;
    }


}
