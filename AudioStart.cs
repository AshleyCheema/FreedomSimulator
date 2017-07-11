using UnityEngine;
using System.Collections;

public class AudioStart : MonoBehaviour
{
    public AudioVolume audioVolume;

	// Use this for initialization
	void Start ()
    {
        audioVolume.PlayMusic();
	}
}
