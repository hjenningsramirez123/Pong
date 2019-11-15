using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSound : MonoBehaviour
{

    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Play the sound when the ball bounces off of it
    private void OnCollisionEnter2D(Collision2D col)
    {
        audio.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
