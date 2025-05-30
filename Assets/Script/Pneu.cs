using UnityEngine.UI;

public class Pneu : Office
{
    private void Update()
    {
        slider.maxValue = Data.numberPneu;
    }

    public void Vendre(Slider input)
    {
        Data.numberPneuInvendu += (int)slider.value;
        Data.numberPneu -= (int)slider.value;
    }

    public void VendreTout(Slider input)
    {
        Data.numberPneuInvendu += Data.numberPneu;
        Data.numberPneu = 0;
    }
}
