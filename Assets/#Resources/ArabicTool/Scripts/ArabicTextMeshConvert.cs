using ArabicTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabicTextMeshConvert : ArabicConvert_Base
{
    [SerializeField] private TextMesh textMesh;

    override public void SetArabText()
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
