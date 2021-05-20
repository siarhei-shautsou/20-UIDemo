using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public void Expand()
    {
        GetComponent<Animator>().SetBool("isSelected", true);
    }

    public void Collapse()
    {
        GetComponent<Animator>().SetBool("isSelected", false);
    }
}
