using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadProgresBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI text;
    float time = 0.25f;

    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            slider.value += 5;
            if(text.text.Length == 10)
            {
                text.text = "LOADING";
            }
            else
            {
                text.text += ".";
            }
            
            time = 0.25f;
        }

        if(slider.value == 100)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
