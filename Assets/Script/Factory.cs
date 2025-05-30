using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textFactory;
    public List<AutoCliper> _autoClipers;

    

    public int stock;

    //public bool isMaxCliper;

    public string fabric = "Tires";
    public int NuAutoCliper;

    public void AfficheInfo()
    {
        textFactory.text = fabric + " in Factory : " + stock;
    }

    public void ClickTheButton()
    {
        if(fabric == "Tires")
        {
            if (Data.numberMatierePneu >= 2)
            {
                stock += 1;
                Data.numberMatierePneu -= 2;
            }
        }
        else
        {
            if (Data.numberMatiereVoiture >= 2 && Data.numberPneu >= 4)
            {
                stock += 1;
                Data.numberMatiereVoiture -= 2;
                Data.numberPneu -= 4;
            }
        }
        
    }

    public void AddtoGlobal()
    {
        if (fabric == "Tires") 
        {
            Data.numberPneu += stock;
            stock = 0;
        }
        else
        {
            Data.numberVoiture += stock;
            stock = 0;
        }
        textFactory.text = fabric + " in Factory : " + stock;
    }

    public void CreateAutoCliper()
    {
        _autoClipers[NuAutoCliper].IsActive = true;
        NuAutoCliper += 1;
    }

    public void UpgradeAutoCliper(int NumClipper)
    {
        _autoClipers[NumClipper].UpgradeAutoCliper();
    }
}
