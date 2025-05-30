using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [Header("-------- Audio SFX Source --------")]
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio SFX Clip --------")]
    public AudioClip buttonClick;
    public AudioClip addStock;
    public AudioClip AutoCliper;
    public AudioClip officeOpen;
    public AudioClip usineOpen;



    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }



}
