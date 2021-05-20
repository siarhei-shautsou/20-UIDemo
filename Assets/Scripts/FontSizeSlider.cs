using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FontSizeSlider : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] textsToChange;
    [SerializeField] TextMeshPro sceneText;

    List<float> initialFontSize = new List<float>();
    float initialSceneFontSize;

    private void Start()
    {
        for (int i = 0; i < textsToChange.Length; i++) // remembers initial font sizes
        {
            initialFontSize.Add(textsToChange[i].fontSize);
        }

        initialSceneFontSize = sceneText.fontSize; // remembers initial font size
    }

    public void ChangeFontsSize(float changeRate)
    {
        for (int i = 0; i < textsToChange.Length; i++)
        {
            if (Localisator.isEnglish)
                textsToChange[i].fontSize = initialFontSize[i] * changeRate;
            else
            {
                if (i == 0 || i == 1 || i == 8 || i == 13 || i == 14)
                {
                    if (changeRate < 1.4f)
                        textsToChange[i].fontSize = initialFontSize[i] * changeRate;
                }
                else
                    textsToChange[i].fontSize = initialFontSize[i] * changeRate;
            }
                
        }

        ParamsKeeper.Size = initialSceneFontSize * changeRate;
    }
}
