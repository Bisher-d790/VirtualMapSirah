using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController_Peninsula : AnimationController_Base
{
    [SerializeField] private Slider timelineSlider;

    [Header("Clip-1")]
    [SerializeField]private ArabicConvert_Base currentTime;
    [SerializeField]private ArabicConvert_Base sidePanelText;

    [Header("Clip-2")]
    [SerializeField]private ArabicConvert_Base almadinaStayersText;
    [SerializeField] private ArabicConvert_Base bottomPanelText;

    [Header("Clip-3")]
    [SerializeField] private ArabicConvert_Base masjidsText;

    IEnumerator PlayClip_1()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        sidePanelText.arabicText = " -اَخر غزوة للرسول \n \n -دامت 20 يوم \n \n -قابلت سنة عسرة ";
        sidePanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }

    IEnumerator PlayClip_2()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 1";
        currentTime.SetArabText();

        almadinaStayersText.arabicText = "علي رضي الله عنه\nالمخلفون\nالمعذرون\nالمنافقون";
        almadinaStayersText.SetArabText();

        bottomPanelText.arabicText = "من بقي في المدينة";
        bottomPanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }

    IEnumerator PlayClip_3()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0.5f;
        currentTime.arabicText = "رجب \n 15";
        currentTime.SetArabText();

        masjidsText.arabicText = "بناء 17 مسجد\nبين المدينة وتبوك";
        masjidsText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
}
