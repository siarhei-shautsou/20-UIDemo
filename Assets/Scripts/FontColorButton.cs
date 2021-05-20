using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FontColorButton : MonoBehaviour
{
    TextMeshProUGUI[] _texts;    

    private void Start()
    {
        _texts = TextsToColor.texts;
    }

    public void ChangeColor()
    {
        for (int i = 0; i < _texts.Length; i++)
        {
            if (_texts[i].color != gameObject.GetComponent<Button>().colors.normalColor)
            {
                _texts[i].color = gameObject.GetComponent<Button>().colors.normalColor;
                ParamsKeeper.Color = _texts[i].color;
            }
        }
    }
}
