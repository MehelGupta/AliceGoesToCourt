using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public float speed; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = 0.0f;
        float vertical = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            horizontal = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            horizontal = speed;
        }

        if (Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
        {
            vertical = speed;
        }
        if (Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
        {
            vertical = -speed;
        }

        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal ;
        position.y = position.y + 0.1f * vertical ;
        transform.position = position;
    }
}
