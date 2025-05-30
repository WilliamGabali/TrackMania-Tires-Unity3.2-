using TMPro;
using UnityEngine;

public class LVMarketingPneu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nlevel;
    [SerializeField] TextMeshProUGUI LevelPrix;
    [SerializeField] GameObject prefabInfo;
    [SerializeField] Transform prefTrans;

    private void Start()
    {
        Data.LVMarketingPneu = 1;
        LevelPrix.text = (Data.LVMarketingPneu * 10000 * 2).ToString() + " €";
        Nlevel.text = Data.LVMarketingPneu.ToString();
    }

    public void Upgrade()
    {
        if (Data.numberEuro >= Data.LVMarketingPneu * 10000 * 2)
        {
            Data.numberEuro -= Data.LVMarketingPneu * 10000 * 2;
            Data.LVMarketingPneu += 1;
            Nlevel.text = Data.LVMarketingPneu.ToString();
            LevelPrix.text = (Data.LVMarketingPneu * 10000 * 2).ToString() + " €";
        }
        else
        {
            GameObject Info = Instantiate(prefabInfo, prefTrans);
            Destroy(Info, 2);
        }
    }
}
