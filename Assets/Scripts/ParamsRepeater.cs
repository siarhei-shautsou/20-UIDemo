using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParamsRepeater : MonoBehaviour
{
    [SerializeField] TextMeshPro text;

    void Update()
    {
        if (ParamsKeeper.isColorChanded)
        {
            text.color = ParamsKeeper.Color;
            ParamsKeeper.isColorChanded = false;
        }

        if (ParamsKeeper.isSizeChanded)
        {
            text.fontSize = ParamsKeeper.Size;
            ParamsKeeper.isSizeChanded = false;
        }

        if (ParamsKeeper.isTextChanged)
        {
            text.text = ParamsKeeper.Text;
            ParamsKeeper.isTextChanged = false;

            if (Localisator.isEnglish)
                text.characterSpacing = 20;
            else
                text.characterSpacing = 5;
        }
    }
}
