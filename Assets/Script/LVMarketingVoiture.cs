using TMPro;
using UnityEngine;

public class LVMarketingVoiture : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Nlevel;
    [SerializeField] TextMeshProUGUI LevelPrix;
    [SerializeField] GameObject prefabInfo;
    [SerializeField] Transform prefTrans;

    private void Start()
    {
        Data.LVMarketingVoiture = 1;
        LevelPrix.text = (Data.LVMarketingVoiture * 10000 * 5).ToString() + " €";
        Nlevel.text = Data.LVMarketingVoiture.ToString();
    }

    public void Upgrade()
    {
        if(Data.numberEuro >= Data.LVMarketingVoiture * 10000 * 5)
        {
            Data.numberEuro -= Data.LVMarketingVoiture * 10000 * 5;
            Data.LVMarketingVoiture += 1;
            Nlevel.text = Data.LVMarketingVoiture.ToString();
            LevelPrix.text = (Data.LVMarketingVoiture * 10000 * 5).ToString() + " €";
        }
        else
        {
            GameObject Info = Instantiate(prefabInfo, prefTrans);
            Destroy(Info, 2);
        }
    }
}
