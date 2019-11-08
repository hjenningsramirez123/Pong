using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public string Up;
    public string Down;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        // Move up if the player is holding Up and it's not at maximum height
        if (Input.GetKey(Up) && transform.position.y < 3)
        {
            transform.position = transform.position + new Vector3(0, Speed * Time.deltaTime, 0);
        }
        // Move down if the player is holding Down and it's not at minimum height
        if(Input.GetKey(Down) && transform.position.y > -3)
        {
            transform.position = transform.position + new Vector3(0, -Speed * Time.deltaTime, 0);
        }
    }
}
