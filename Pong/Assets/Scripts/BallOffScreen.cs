using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallOffScreen : MonoBehaviour
{
    public Text TextLeft;
    public Text TextRight;

    private Rigidbody2D myRB;
    private BallInitMove init;

    int scoreLeft, scoreRight;

    // Start is called before the first frame update
    void Start()
    {
        init = GetComponent<BallInitMove>();
        myRB = GetComponent<Rigidbody2D>();
        scoreLeft = 0;
        scoreRight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.x) > 10)
        {
            string winner = null;
            if (transform.position.x > 0)
            {
                scoreLeft++;
                TextLeft.text = scoreLeft.ToString();
                if(scoreLeft == 11)
                {
                    winner = "Left";
                }
            }
            else
            {
                scoreRight++;
                TextRight.text = scoreRight.ToString();
                if(scoreRight == 11)
                {
                    winner = "Right";
                }
            }
            transform.position = new Vector3(0, 0, 0);
            myRB.velocity = new Vector3(0, 0, 0);
            init.StartCoroutine("Initialize");
        }
    }
}
