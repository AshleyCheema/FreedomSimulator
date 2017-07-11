using UnityEngine;
using System.Collections;

//script used to see if we want to enable gravity on progectiles
//this is used so bullets dont droop when fired but also dont float randomly away when they collide with other objects



public class Gravity : MonoBehaviour {
    //nullreference happens but does not change gameplay

    public Rigidbody RB;
    public AudioVolume audioVolume;

    // Use this for initialization
    void Start ()
    {
        audioVolume = GetComponent<AudioVolume>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	}



    void OnCollisionEnter(Collision coll)
    {
        //if enemies hit self or other enemies ignore for gravity
        if (coll.gameObject.tag == "Enemy")
        {

        }
        else if (coll.gameObject.tag == "Claw")
        {
            Destroy(this);
        }

        else
        {
            //turn gravity sound on
            RB.useGravity = true;
            audioVolume.PlayMusic();
        }

    }


}
