using TMPro;
using UnityEngine;

public class PrixPneu : Office
{
    [SerializeField] TextMeshProUGUI textPD;
    [SerializeField] TextMeshProUGUI textSInvendu;
    float timeVente = 0.05f;
    float actualiseVente = 1;
    int pneuVendu;

    private void Update()
    {
        float PD = (float)System.Math.Pow(1.1, Data.LVMarketingPneu - 1) * (1.5f * 2 * 2 * 5 * 10) * (0.1f / (slider.value / 100));
        textPD.text = PD.ToString() + " %";
        if (Data.numberPneuInvendu - pneuVendu > 0 && timeVente <= 0)
        {
            int chance = Random.Range(1, 100);
            if (chance <= PD - 20)
            {
                pneuVendu += 1;
            }
            timeVente = 0.05f;
        }
        timeVente -= Time.deltaTime;
        if (actualiseVente <= 0)
        {
            Data.numberPneuInvendu -= pneuVendu;
            Data.numberEuro += pneuVendu * slider.value;
            textSInvendu.text = Data.numberPneuInvendu.ToString();
            pneuVendu = 0;
            actualiseVente = 1;
        }
        actualiseVente -= Time.deltaTime;
    }
}
