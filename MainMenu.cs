using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    private bool Menu = true;

    //Needed for menu buttons to appear
    void OnGUI()
    {
        FirstMenu();
    }

    // These are specific details create the buttons and the layout
    void FirstMenu()
    {
        if (Menu)
        {
            // if the player were to press the "Start Game" they will be loaded into the main game

            if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 120, 200, 60), "New Game"))
            {
                Application.LoadLevel("scene1");
                //SceneManager.LoadScene(1);
            }

            //Pressing the "Quit Game" button will quit the game
            if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 - 50, 200, 60), "Continue"))
            {
                //Application.Quit();
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 - -20, 200, 60), "Load Save"))
            {
                //Application.LoadLevel("");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 - -90, 200, 60), "Options"))
            {
               // Application.LoadLevel("");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 80, Screen.height / 2 - -160, 200, 60), "Quit Game"))
            {
                Application.Quit();
            }















        }
    }

}

