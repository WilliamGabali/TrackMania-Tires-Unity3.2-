using TMPro;
using UnityEngine;

public class MPPneu : Office
{
    int prix;
    float timePrix = 10;

    [SerializeField] Transform prefTrans;

    [SerializeField] GameObject prefabInfo;

    [SerializeField] TextMeshProUGUI PrixText;

    [SerializeField] TextMeshProUGUI TotalPrix;
    private void Start()
    {
        RandomPrix();
    }

    private void Update()
    {
        timePrix -= Time.deltaTime;
        if(timePrix <= 0)
        {
            timePrix = 10;
            RandomPrix();
        }
        slider.maxValue = 1000 - Data.numberMatierePneu;
        TotalPrix.text = (slider.value * prix).ToString() + " €";
    }
    public void RandomPrix()
    {
        prix = Random.Range(8, 20);
        PrixText.text = prix.ToString() + " €";
    }
    public void Acheter()
    {
        if (slider.value * prix > Data.numberEuro)
        {
            GameObject Info = Instantiate(prefabInfo, prefTrans);
            Destroy(Info,2);
        }
        else
        {
            Data.numberEuro -= slider.value * prix;
            Data.numberMatierePneu += (int)slider.value;
        }
    }
}
