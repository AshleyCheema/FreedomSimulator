using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;






//public static void LoadScene(int sceneBuildIndex, SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
public class EndLevel : MonoBehaviour {

    //This scripts has a short timer that allows for the animation to play before changing to the next level

    public Animator Open;
    public float Timer;
	public GameObject Keybindingss;
        public static DontDestory instance;
    void Start()
    {
        Open.enabled = false;

    }

    void OnTriggerStay(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Open.enabled = true;

            Timer = Timer - Time.deltaTime;

            if (Timer <= 0)
            {
                // SceneManager.UnloadScene(1);
                //.LoadScene(2);
                // SceneManager.UnloadScene(1);

                Application.LoadLevel(2);
            }

        }
    }



      



}
