using UnityEngine;
using System.Collections;

public class ShowMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject Keybindings;
    //public GameObject PauseMenu;

    //Showing and Hiding Main Menu
    public void ShowMainMenu()
    {
        MainMenu.SetActive(true);
    }

    public void HideMainMenu()
    {
        MainMenu.SetActive(false);
    }

    //Showing and Hiding Options Menu
    public void ShowOptions()
    {
        OptionsMenu.SetActive(true);
    }

    public void HideOptions()
    {
        OptionsMenu.SetActive(false);
    }
    //Showing and Hiding Keybindings Menu

    public void ShowKeybindings()
    {
        Keybindings.SetActive(true);
    }

    public void HideKeybindings()
    {
        Keybindings.SetActive(false);
    }
    
}
