using TMPro;
using UnityEngine;

public class AfficheName : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    void Start()
    {
        text.text = Data.nameUsine;
    }
}
