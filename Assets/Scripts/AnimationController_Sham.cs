using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController_Sham : AnimationController_Base
{
    [SerializeField] private Slider timelineSlider;
    [SerializeField] private ArabicConvert_Base currentTime;
    [SerializeField] private ArabicConvert_Base bottomPanelText;
    [SerializeField] private ArabicConvert_Base sidePanelText;

    IEnumerator PlayClip_1()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        yield return new WaitForEndOfFrame();
    }
}
