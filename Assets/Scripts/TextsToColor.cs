using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextsToColor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI[] textsToColor;

    public static TextMeshProUGUI[] texts;

    private void Awake()
    {
        texts = textsToColor;
    }
}
