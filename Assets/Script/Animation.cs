using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    [SerializeField] Animator animator;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void setAnime(bool a)
    {
        audioManager.PlaySFX(audioManager.officeOpen);
        animator.SetBool("IsDown", a);
    }
}
