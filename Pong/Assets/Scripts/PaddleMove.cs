using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    public string Up;
    public string Down;
    public float Speed;

    private float speedMul;

    private new AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        speedMul = 1;
    }

    // Play the sound when the ball bounces off of it
    private void OnCollisionEnter2D(Collision2D col)
    {
        audio.Play(0);
    }

    void FixedUpdate()
    {
        if (speedMul < 3)
        {
            speedMul += Time.deltaTime / 10;
        }
        // Move up if the player is holding Up and it's not at maximum height
        if (Input.GetKey(Up) && transform.position.y < 3)
        {
            transform.position = transform.position + new Vector3(0, Speed * Time.deltaTime * speedMul, 0);
        }
        // Move down if the player is holding Down and it's not at minimum height
        if(Input.GetKey(Down) && transform.position.y > -3)
        {
            transform.position = transform.position + new Vector3(0, -Speed * Time.deltaTime * speedMul, 0);
        }
    }
}
