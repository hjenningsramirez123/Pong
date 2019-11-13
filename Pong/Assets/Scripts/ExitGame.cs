using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    public void CloseGame()
    {
        //Closes game when pushed
        UnityEngine.UI.Button.
        Quit.gameObject.onClick.AddListener(Application.Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
