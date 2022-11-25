using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject[] dogPrefabs;

    public float timer;
    private float timeLimit = 1.0f;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Bonus - Limits the player to spawn dogs every 1 second only
        if (Input.GetKeyDown(KeyCode.Space) && timer > timeLimit)
        {
            // On spacebar press, send dog
            SpawnDog();
            timer = 0;
        }
    }

    // Spawn a ramdom dog
    void SpawnDog()
    {
        int dogIndex = Random.Range(0, dogPrefabs.Length);

        Instantiate(dogPrefabs[dogIndex], transform.position, dogPrefabs[dogIndex].transform.rotation);
    }
}
