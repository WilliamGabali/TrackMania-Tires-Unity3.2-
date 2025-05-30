using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tires;
    [SerializeField] TextMeshProUGUI auto;
    [SerializeField] TextMeshProUGUI money;
    void Update()
    {
        tires.text = "Tires : " + Data.numberPneu;
        auto.text = "Auto : " + Data.numberVoiture;
        money.text = "Money : " + Data.numberEuro;
    }
}
