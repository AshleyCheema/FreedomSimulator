using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AudioVolume : MonoBehaviour
{
    public AudioClip clipMusic;
    public AudioMixerSnapshot volumeUp;
    public AudioMixerSnapshot volumeDown;
    public AudioSource soundEffect;

    private AudioSource musicSource;

	// Use this for initialization
	void Start ()
    {
        musicSource = GetComponent<AudioSource>();
	}
	
	public void PlayMusic()
    {
        musicSource.clip = clipMusic;
        musicSource.Play();
    }

    public void VolumeUp(float Volume)
    {
        volumeUp.TransitionTo(Volume);
    }

    public void VolumeDown(float Volume)
    {
        volumeDown.TransitionTo(Volume);
    }

}
