using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallOffScreen : MonoBehaviour
{
    public Text TextLeft;
    public Text TextRight;
    public GameObject cam;

    public static string Winner = null;

    private CameraShake shake;

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
        shake = cam.GetComponent<CameraShake>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the ball is on the edge of the screen
        if(Mathf.Abs(transform.position.x) > 10)
        {
            // Increment score for the correct player
            if (transform.position.x > 0)
            {
                scoreLeft++;
                TextLeft.text = scoreLeft.ToString();
                // Check if that player has won
                if(scoreLeft == 11)
                {
                    Winner = "left";
                }
            }
            else
            {
                scoreRight++;
                TextRight.text = scoreRight.ToString();
                if(scoreRight == 11)
                {
                    Winner = "right";
                }
            }
            // Make the camera shake
            shake.Reset();
            if(Winner == null)
            {
                // Reset the ball's position and make it idle for Delay before moving
                transform.position = new Vector3(0, -100, 0);
                myRB.velocity = new Vector3(0, 0, 0);
                init.StartCoroutine("Initialize");
            } else
            {
                // If there has been a winner determined, switch to the Win scene
                SceneManager.LoadScene("Win");
            }
        }
    }
}
