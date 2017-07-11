using UnityEngine;
using System.Collections;

public class DontDestoryCanvas : MonoBehaviour {


    public static DontDestoryCanvas instance;
    public GameObject MainMenuPanel;

    void Start ()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        /*if (Application.loadedLevel != 0)
        {
            MainMenuPanel.SetActive(false);
        }
    */}
}
