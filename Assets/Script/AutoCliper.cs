using UnityEngine;

public class AutoCliper : MonoBehaviour 
{
    public float timeClik = 1;
    public float intTimeClik = 1;
    float UpgradeTimeClick = 0;
    public float intUpgradeTimeClick = 0.1f;
    public Factory factory;
    public bool IsActive;
    public int UpgradeLevel = 1;

    void Update()
    {
        if (IsActive)
        {
            if (timeClik <= 0)
            {
                factory.ClickTheButton();
                timeClik = intTimeClik - UpgradeTimeClick;
            }
            timeClik -= Time.deltaTime;
        }
    }

    public void UpgradeAutoCliper()
    {
        UpgradeTimeClick += intUpgradeTimeClick;
        UpgradeLevel += 1;
    }
}
