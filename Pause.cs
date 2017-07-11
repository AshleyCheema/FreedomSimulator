using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject pause;
    //public GameObject MainMenu;
    private bool paused = false;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame

    //This script shows the pause menu if the player presses the escape key
    //Firstly it stops game time and shows the menus as well as bring the mouse back
	void Update ()
    {
	    if(Input.GetKeyDown("escape"))
        {
            paused = !paused;
        }

        if(paused)
        {
            Canvas.SetActive(true);
            //MainMenu.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            pause.SetActive(true);

        }

        //And if the player was to pressed escape or continue then the pause menu will hide and time will continue
        if (!paused)
        {
            Canvas.SetActive(false);
           // MainMenu.SetActive(false);
            Time.timeScale = 1;
            Cursor.visible = false;
            pause.SetActive(false);
        }
	}

    public void HidePauseMenu()
    {
        Canvas.SetActive(false);
        // MainMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        pause.SetActive(false);
        paused = false;

    }
}
