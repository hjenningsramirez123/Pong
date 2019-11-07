using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOffScreen : MonoBehaviour
{

    public GameObject newBall;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x) > 10)
        {
            GameObject ball = Instantiate(newBall, new Vector3(0, 0, 0), Quaternion.identity);
            ball.name = "Ball";
            Destroy(gameObject);
        }
    }
}
