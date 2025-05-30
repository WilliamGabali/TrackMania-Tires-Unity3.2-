using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class SButton : Button
{
    [SerializeField] bool _EffectIsActif;
    [SerializeField] bool _EffectScale;
    [SerializeField] float scale = 0.001f;
    // Update is called once per frame
    void Update()
    {
        if (IsHighlighted() == true)
        {
            _EffectIsActif = true;
            if(gameObject.transform.localScale.x >= 3.7)
            {
                _EffectScale = true;
            }
            else if(gameObject.transform.localScale.x <= 3.5)
            {
                _EffectScale = false;
            }
        }
        else if(IsHighlighted() == false)
        {
            gameObject.transform.localScale = new Vector3(3.5f, 3.5f, 3.5f);
            _EffectIsActif = false;
        }

        if(_EffectIsActif && _EffectScale)
        {
            gameObject.transform.localScale -= new Vector3(scale, scale, scale);
        }
        else if(_EffectIsActif && !_EffectScale)
        {
            gameObject.transform.localScale += new Vector3(scale, scale, scale);
        }
    }
}
