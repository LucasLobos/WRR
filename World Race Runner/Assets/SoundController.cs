
using System;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    private AudioSource _audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        _audioSource.PlayOneShot(sound);
    }
}
