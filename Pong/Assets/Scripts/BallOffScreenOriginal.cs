using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallOffScreenOriginal : MonoBehaviour
{
    public Text TextLeft;
    public Text TextRight;
    public GameObject cam;

    public static string WinnerOriginal = null;

    private Rigidbody2D myRB;
    private BallInitMove init;

    int scoreLeftOriginal, scoreRightOriginal;

    // Start is called before the first frame update
    void Start()
    {
        init = GetComponent<BallInitMove>();
        myRB = GetComponent<Rigidbody2D>();
        scoreLeftOriginal = 0;
        scoreRightOriginal = 0;
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
                scoreLeftOriginal++;
                TextLeft.text = scoreLeftOriginal.ToString();
                // Check if that player has won
                if(scoreLeftOriginal == 11)
                {
                    WinnerOriginal = "left";
                }
            }
            else
            {
                scoreRightOriginal++;
                TextRight.text = scoreRightOriginal.ToString();
                if(scoreRightOriginal == 11)
                {
                    WinnerOriginal = "right";
                }
            }
            if(WinnerOriginal == null)
            {
                // Reset the ball's position and make it idle for Delay before moving
                transform.position = new Vector3(0, -100, 0);
                myRB.velocity = new Vector3(0, 0, 0);
                init.StartCoroutine("Initialize");
            } else
            {
                // If there has been a winner determined, switch to the Win scene
                SceneManager.LoadScene("Win");
                scoreLeftOriginal = 0;
                scoreRightOriginal = 0;
            }
        }
    }
}
