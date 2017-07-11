using UnityEngine;
using System.Collections;

public class AnimationTrigger : MonoBehaviour
{

    public Animator anim;
    public AudioVolume audioVolume;


    // Use this for initialization
    void Start()
    {
        anim.enabled = false;

    }

    //This plays a sound as well as an animation then the box collider is turned off so that the user can't make the sound go off again

    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            audioVolume.PlayMusic();
            anim.enabled = true;
            GetComponent<Collider>().enabled = false;
        }
          

    }
}
