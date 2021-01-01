using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController_Peninsula : AnimationController_Base
{
    [SerializeField]private ArabicConvert_Base currentTime;
    [SerializeField]private ArabicConvert_Base sidePanelText;

    IEnumerator PlayClip_1()
    {
        Time.timeScale = 0.1f;

        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        sidePanelText.arabicText = " -اَخر غزوة للرسول \n \n -دامت 20 يوم \n \n -قابلت سنة عسرة ";
        sidePanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
}
