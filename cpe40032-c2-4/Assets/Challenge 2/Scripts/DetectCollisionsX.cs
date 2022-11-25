using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    // Destroy the ball if the dog catched it
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
