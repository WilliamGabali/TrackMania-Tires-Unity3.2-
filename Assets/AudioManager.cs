using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AudioManager : MonoBehaviour
{

    [Header("-------- Audio  Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio  Clip --------")]
    public AudioClip background;
    public AudioClip buttonClick;
    public AudioClip addStock;
    public AudioClip AutoCliper;
    public AudioClip officeOpen;
    public AudioClip usineOpen;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }


}
