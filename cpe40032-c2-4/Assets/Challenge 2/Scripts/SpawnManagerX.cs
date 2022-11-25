using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private float minTime = 3.0f;
    private float maxTime = 5.0f;
    public float spawnTimeInterval;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
 
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }


    // Bonus: Spawn balls randomly from 3 to 5 seconds
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTimeInterval)
        {
            spawnTimeInterval = Random.Range(minTime, maxTime);
            timer = 0;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
