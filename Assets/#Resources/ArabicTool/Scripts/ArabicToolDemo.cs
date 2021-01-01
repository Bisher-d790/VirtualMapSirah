using UnityEngine;
using UnityEngine.UI;
using ArabicTool;
using System.Text;

public class ArabicToolDemo : MonoBehaviour
{
    [SerializeField] private SeniorText seniorText;
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
        if(seniorText)
        {
            SeniorText text1 = seniorText.GetComponent<SeniorText>();
            text1.text = "";
            text1.text = null;

            text1.text = arabicText;
        }

        string co = ArabicTextTool.Convert("");
        string rstr = ArabicTextTool.ReverseOnly(co);

    }

}
