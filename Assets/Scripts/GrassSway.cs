using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSway : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has a specific tag
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with Player!");
            // Perform actions when colliding with the player
        }
    }
}
