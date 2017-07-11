using UnityEngine;
using System.Collections;

public class Elevator2 : MonoBehaviour {

    public Animator Elevator;
    public AudioVolume audioVolume;


    // Use this for initialization
    void Start()
    {
        

    }
    //When the player enters the elevator it will play the correct sound and also disables the colliders
    //This is done so the sound does not continue when the player goes back to it
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            audioVolume.PlayMusic();
            Elevator.SetBool("Play", true);
            GetComponent<Collider>().enabled = false;
        }


    }
}
