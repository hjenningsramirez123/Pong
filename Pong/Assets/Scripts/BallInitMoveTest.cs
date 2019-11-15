using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInitMoveTest : MonoBehaviour
{

    public float Speed = 350;
    public float Delay = 1;

    private Rigidbody2D myRB;
 
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        // Make the ball start moving after Delay
        StartCoroutine("Initialize");
    }

    IEnumerator Initialize()
    {
        //Wait Delay seconds
        yield return new WaitForSeconds(Delay);
        transform.position = new Vector3(0, 0, 0);
        // Give the ball a random motion vector that doesn't point too far up or down and has a length Speed
        float dir = Random.Range(Mathf.PI / -4, Mathf.PI / 4);
        if (Random.Range(0, 2) == 1)
        {
            dir += Mathf.PI;
        }
        Vector2 move = new Vector2(Mathf.Cos(dir) * Speed, Mathf.Sin(dir) * Speed);
        myRB.AddForce(move);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
