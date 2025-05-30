using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOption : MonoBehaviour
{
    public GameObject Panel;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OpenPanel()
    {
        if (Panel != null)
        {
            audioManager.PlaySFX(audioManager.buttonClick);

            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
