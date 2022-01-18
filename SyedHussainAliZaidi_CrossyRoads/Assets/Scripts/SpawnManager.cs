using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //for setting spawn position from outside
    public float sideSpawnMinZ = 2;
    public float sideSpawnMaxZ = 20;
    public float sideSpawnX = 24;


    //for Spawning car Object after 2 second and after intervals of 1 second each
    private float startDelay = 2;
    private float spawnInterval = 1.0f;

    public GameObject[] carPrefabLeft;
    public GameObject[] carPrefabRight;

    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCarLeft", startDelay, spawnInterval);
        InvokeRepeating("SpawnCarRight", startDelay, spawnInterval);

        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpawnCarLeft()
    {

        if (!playerControllerScript.gameOver)
        {
            if (!playerControllerScript.win)
            {
                int carIndex = Random.Range(0, carPrefabLeft.Length);
                Vector3 spawnPos = new Vector3(sideSpawnX, 2, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
                Instantiate(carPrefabLeft[carIndex], spawnPos, carPrefabLeft[carIndex].transform.rotation);
            }
        }
       
    }
    void SpawnCarRight()
    {
        if (!playerControllerScript.gameOver)
        {
            if (!playerControllerScript.win)
            {
                int carIndex = Random.Range(0, carPrefabRight.Length);
                Vector3 spawnPos = new Vector3(-sideSpawnX, 2, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
                Instantiate(carPrefabRight[carIndex], spawnPos, carPrefabRight[carIndex].transform.rotation);
            }
        }
    }

}

