using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainFactory : MonoBehaviour
{
    [SerializeField] List<Factory> _factories;

    [SerializeField] GameObject Button;
    [SerializeField] TextMeshProUGUI ButtonBuyText;

    [SerializeField] Transform prefTrans;

    [SerializeField] GameObject prefabInfo;

    [SerializeField] List<GameObject> autoClip;

    [SerializeField] List<TextMeshProUGUI> textPrixUpgrade;

    [SerializeField] List<TextMeshProUGUI> textLVUpgrade;

    [SerializeField] List<GameObject> buttonUpgrade;

    [SerializeField] TextMeshProUGUI mat;

    [SerializeField] int prixUpgrade = 1000;



    int totalCliper;

    int NFactory;
    // Update is called once per frame

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        _factories[NFactory].AfficheInfo();
        
        if(_factories[NFactory].fabric == "Tires")
        {
            for (int i = 0; i < _factories[NFactory].NuAutoCliper; i++)
            {
                autoClip[i].transform.GetComponentInChildren<Slider>().value = -(_factories[NFactory]._autoClipers[i].timeClik - 1);
            }
            mat.text = Data.numberMatierePneu.ToString();
        }
        else
        {
            for (int i = 0; i < _factories[NFactory].NuAutoCliper; i++)
            {
                autoClip[i].transform.GetComponentInChildren<Slider>().value = -(_factories[NFactory]._autoClipers[i].timeClik - 5);
            }
            mat.text = Data.numberMatiereVoiture.ToString();
        }
    }

    public void SetMainFactory(int factory)
    {
        NFactory = factory;
        if (_factories[NFactory].NuAutoCliper == 3)
        {
            Button.SetActive(false);
            AfficheAutoClip(_factories[NFactory].NuAutoCliper);
        }
        else
        {
            AfficheAutoClip(_factories[NFactory].NuAutoCliper);
            Button.SetActive(true);
            ButtonBuyText.text = ((totalCliper + 1) * 3000).ToString() + " €";
        }
    }
    public void AfficheAutoClip(int N)
    {
        for (int i = 0; i < 3; i++)
        {
            autoClip[i].SetActive(false);
        }
        for (int i = 0; i < N; i++)
        {
            autoClip[i].SetActive(true);
            textAutoClip(i);
        }
    }

    public void ClickTheButton()
    {
        _factories[NFactory].ClickTheButton();
        audioManager.PlaySFX(audioManager.buttonClick);
    }

    public void AddtoGlobal()
    {
        _factories[NFactory].AddtoGlobal();
        audioManager.PlaySFX(audioManager.addStock);
    }

    public void CreateAutoCliper()
    {
        if (Data.numberEuro >= (totalCliper + 1) * 3000)
        {
            Data.numberEuro -= (totalCliper + 1) * 3000;
            totalCliper += 1;
            ButtonBuyText.text = ((totalCliper + 1) * 3000).ToString() + " €";
            _factories[NFactory].CreateAutoCliper();
            AfficheAutoClip(_factories[NFactory].NuAutoCliper);

            audioManager.PlaySFX(audioManager.AutoCliper);

            if (_factories[NFactory].NuAutoCliper == 3)
            {
                Button.SetActive(false);
            }
        }
        else
        {
            Message();
        }
    }

    public void UpgradeAutoCliper(int NumClipper)
    {
        if (Data.numberEuro > _factories[NFactory]._autoClipers[NumClipper].UpgradeLevel * prixUpgrade)
        {
            _factories[NFactory].UpgradeAutoCliper(NumClipper);
            textAutoClip(NumClipper);

            audioManager.PlaySFX(audioManager.AutoCliper);
        }
        else
        {
            Message();
        }
    }

    public void textAutoClip(int NumClipper)
    {
        textPrixUpgrade[NumClipper].text = (_factories[NFactory]._autoClipers[NumClipper].UpgradeLevel * prixUpgrade).ToString() + " €";
        if (_factories[NFactory]._autoClipers[NumClipper].UpgradeLevel == 5)
        {
            buttonUpgrade[NumClipper].SetActive(false);
            textLVUpgrade[NumClipper].text = "Level : MAX";
        }else
        {
            buttonUpgrade[NumClipper].SetActive(true);
            textLVUpgrade[NumClipper].text = "Level : " + _factories[NFactory]._autoClipers[NumClipper].UpgradeLevel;
        }
    }

    public void Message()
    {
        GameObject Info = Instantiate(prefabInfo, prefTrans);
        Destroy(Info, 2);
    }
}