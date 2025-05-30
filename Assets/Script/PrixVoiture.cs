using TMPro;
using UnityEngine;

public class PrixVoiture : Office
{
    [SerializeField] TextMeshProUGUI textPD;
    [SerializeField] TextMeshProUGUI textSInvendu;
    float timeVente = 0.01f;
    float actualiseVente = 1;
    int voitureVendu;

    private void Update()
    {
        float PD = (float)System.Math.Pow(1.1, Data.LVMarketingVoiture - 1) * (1.5f * 2 * 2 * 5 * 10) * (0.05f / (slider.value / 100));
        textPD.text = PD.ToString() + " %";
        if (Data.numberVoitureInvendu - voitureVendu > 0 && actualiseVente <= 0)
        {
            int chance = Random.Range(1, 100);
            if (chance <= PD)
            {
                voitureVendu += 1;
            }
            Data.numberVoitureInvendu -= voitureVendu;
            Data.numberEuro += voitureVendu * slider.value;
            textSInvendu.text = Data.numberVoitureInvendu.ToString();
            voitureVendu = 0;
            actualiseVente = 1;
        }
        actualiseVente -= Time.deltaTime;
    }
}
