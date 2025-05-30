using UnityEngine;

public class ChangeData : MonoBehaviour
{
    [SerializeField] float numberEuro;
    [SerializeField] int numberPneu;
    [SerializeField] int numberPneuInvendu;
    [SerializeField] int numberVoiture;
    [SerializeField] int numberVoitureInvendu;
    [SerializeField] int numberMatierePneu;
    [SerializeField] int numberMatiereVoiture;
    [SerializeField] int LVMarketingVoiture;
    [SerializeField] int LVMarketingPneu;
    private void Start()
    {
        Data.numberEuro = numberEuro ;
        Data.numberPneu = numberPneu;
        Data.numberPneuInvendu = numberPneuInvendu;
        Data.numberVoiture = numberVoiture;
        Data.numberVoitureInvendu = numberVoitureInvendu;
        Data.numberMatierePneu = numberMatierePneu;
        Data.numberMatiereVoiture = numberMatiereVoiture;
        Data.LVMarketingVoiture = LVMarketingVoiture;
        Data.LVMarketingPneu = LVMarketingPneu;
    }
}
