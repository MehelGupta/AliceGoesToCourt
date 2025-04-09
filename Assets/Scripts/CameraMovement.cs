using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        //get the players position and add it with offset, then store it to transform.position aka the cameras position
        transform.position = player.position + offset;
    }
}
