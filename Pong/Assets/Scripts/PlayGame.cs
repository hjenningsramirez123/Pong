using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenGame()
    {
        // Loads scene when button is pushed
        SceneManager.LoadScene("Game");
    }

    public void OpenGameNew()
    {
        // Loads scene when button is pushed
        SceneManager.LoadScene("GameNew");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
