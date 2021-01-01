using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ArabicConvert_Base : MonoBehaviour
{
    public string arabicText;

    // Use this for initialization
    void Start()
    {
        SetArabText();
    }

    public abstract void SetArabText();
}
