using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class MainMenuScript01 : MonoBehaviour
{
    private AudioSource Audio;
    public Slider VolumeSlider;
    
    private ShowMenu ShowMenu;

    void Awake()
    {
        ShowMenu = GetComponent<ShowMenu>();
        Audio = GetComponent<AudioSource>();
    }

    //From here downwards are scripts so that when pressing the a button is will hide the previous menu and bring up a new one
    //Some have actual functions like level01 will load the first level
    

    public void Level01 (string scene1)
    {
        Application.LoadLevel(1);
      //  SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        Application.LoadLevel(0);
    }
    
    public void Quit()
    {
        Application.Quit();
    }

    public void Options()
    {
        ShowMenu.ShowOptions();
        ShowMenu.HideMainMenu();
    }

    public void Keybindings()
    {
        ShowMenu.ShowKeybindings();
        ShowMenu.HideOptions();
    }

    public void OptionsBackButton()
    {
        ShowMenu.HideOptions();
        ShowMenu.ShowMainMenu();
    }

    public void KeybindBackButton()
    {
        ShowMenu.HideKeybindings();
        ShowMenu.ShowOptions();
    }
    //These two allow for the control for the volume and mute button
    public void ChangeVolume()
    {
        Audio.volume = VolumeSlider.value;
    }

    public void MuteVolume()
    {
        if (Audio.mute == true)
            Audio.mute = false;
        else
            Audio.mute = true;
    }

}
