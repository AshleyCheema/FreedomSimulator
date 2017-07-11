using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class KeyBindings : MonoBehaviour
{
    public Dictionary<string, KeyCode> keys = new Dictionary<string, KeyCode>();

    public Text up, down, left, right, jump, sswitch, ability;

    private GameObject currentKey;

    private Color32 Normal = new Color32(255, 255, 255, 255);
    private Color32 Selected = new Color32(39, 223, 56, 255);

	// Use this for initialization
	void Start ()
    {
        keys.Add("Up", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Up","W")));
        keys.Add("Down", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Down", "S")));
        keys.Add("Left", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A")));
        keys.Add("Right", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "D")));
        keys.Add("Jump", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Jump", "Space")));
        keys.Add("Switch", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Switch", "C")));
        keys.Add("Ability", (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Ability", "E")));


        up.text       =     keys["Up"].ToString();
        down.text     =     keys["Down"].ToString();
        left.text     =     keys["Left"].ToString();
        right.text    =     keys["Right"].ToString();
        jump.text     =     keys["Jump"].ToString();
        sswitch.text  =     keys["Switch"].ToString();
        ability.text  =     keys["Ability"].ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(keys["Up"]))
        {
         //   Debug.Log("Up");
        }

        if (Input.GetKeyDown(keys["Down"]))
        {

        }

        if (Input.GetKeyDown(keys["Left"]))
        {

        }

        if (Input.GetKeyDown(keys["Right"]))
        {

        }

        if (Input.GetKeyDown(keys["Jump"]))
        {

        }
        if (Input.GetKeyDown(keys["Switch"]))
        {
            //Debug.Log("switch");
        }
    }

    void OnGUI()
    {
        if(currentKey != null)
        {
            Event e = Event.current;
            if(e.isKey)
            {
                keys[currentKey.name] = e.keyCode;
                currentKey.transform.GetChild(0).GetComponent<Text>().text = e.keyCode.ToString();
                currentKey.GetComponent<Image>().color = Normal;
                currentKey = null;
            }
        }
    }

    public void ChangeKey(GameObject clicked)
    {
        if(currentKey != null)
        {
            currentKey.GetComponent<Image>().color = Normal;
        }

        currentKey = clicked;
        currentKey.GetComponent<Image>().color = Selected;
    }

    public void SaveKeys()
    {
        foreach (var key in keys)
        {
            PlayerPrefs.SetString(key.Key, key.Value.ToString());
        }
        PlayerPrefs.Save();
    }
}

