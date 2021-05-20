using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaletteColorButton : MonoBehaviour
{
    [SerializeField] Color color;
    [SerializeField] Image backgroundImage;
    [SerializeField] Material backgroundMaterial;

    public void ChangeColor()
    {
        if (backgroundImage.color != color)
            backgroundImage.color = color;

        if (backgroundMaterial.color != color)
            backgroundMaterial.color = color;
    }
}
