using UnityEngine.UI;

public class Voiture : Office
{
    private void Update()
    {
        slider.maxValue = Data.numberVoiture;
    }
    public void Vendre(Slider input)
    {
        Data.numberVoitureInvendu += (int)slider.value;
        Data.numberVoiture -= (int)slider.value;
    }

    public void VendreTout(Slider input)
    {
        Data.numberVoitureInvendu += Data.numberVoiture;
        Data.numberVoiture = 0;
    }
}
