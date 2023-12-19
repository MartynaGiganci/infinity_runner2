using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource effectSource;
    private bool muted;
    private AudioSource audioSource;
    public AudioClip click;
    public AudioClip jump;
    public AudioClip coinGrab;

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

        audioSource = GetComponent<AudioSource>();
    }
    public void ToggleMuted()
    {
        muted = !muted;
        audioSource.mute = muted;
    }
    public bool GetMuted()
    {
        return muted;
    }
    public void PlayOnceClick()
    {
        if (!muted)
        {
            effectSource.PlayOneShot(click, 1f);
        }
    }
    public void PlayOnceJumped()
    {
        if (!muted)
        {
            effectSource.PlayOneShot(jump, 1f);
        }
    }
    public void PlayCoinGrab()
    {
        if (!muted)
        {
            effectSource.PlayOneShot(coinGrab, 1f);
        }
    }
}