using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Office : MonoBehaviour
{
    [SerializeField] public Slider slider;

    [SerializeField] TMP_InputField text;


    public void ChangeValueSlider(String input)
    {
        slider.value = float.Parse(input, CultureInfo.InvariantCulture.NumberFormat);
    }

    public void ChangeValueText(Single input)
    {
        text.text = input.ToString();
    }
}
