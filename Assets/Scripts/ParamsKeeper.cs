using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamsKeeper : MonoBehaviour
{
    static Color color;
    static float size;
    static string text;
    public static bool isColorChanded;
    public static bool isSizeChanded;
    public static bool isTextChanged;

    public static Color Color
    {
        get
        {
            return color;
        }
        set
        {
            color = value;
            isColorChanded = true;
        }
    }

    public static float Size
    {
        get
        {
            return size;
        }
        set
        {
            size = value;
            isSizeChanded = true;
        }
    }

    public static string Text
    {
        get
        {
            return text;
        }
        set
        {
            text = value;
            isTextChanged = true;
        }
    }
}
