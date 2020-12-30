using ArabicTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabicToolConvert : MonoBehaviour
{
    [SerializeField] private TextMesh textMesh;
    [SerializeField] private string arabicText;

    // Use this for initialization
    void Start()
    {
        SetArabText();
    }

    void SetArabText()
    {
        //Debug.LogError("TestArabText");

        // Use SeniorText of plugin
        if (textMesh)
        {
            //SeniorText text1 = seniorText.GetComponent<SeniorText>();
            textMesh.text = "";
            textMesh.text = null;

            string co = ArabicTextTool.Convert(arabicText);
            string rstr = ArabicTextTool.ReverseOnly(co);
            textMesh.text = rstr;
        }


    }

}
