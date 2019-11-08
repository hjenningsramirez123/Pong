using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetWinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declares who the winner is
        Text txt = GetComponent<Text>();
        txt.text = "The " + BallOffScreen.Winner + " player wins!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
