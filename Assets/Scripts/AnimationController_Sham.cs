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

    [Header("Clip-4")]
    [SerializeField] private float startTimescaleDelay;
    [SerializeField] private float timescaleDelay;
    
    [Header("Clip-5")]
    [SerializeField] private ArabicConvert_Base armyArrangementTextField;

    IEnumerator PlayClip_1()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        bottomPanelText.arabicText = "جمع\n الروم لحرب النبي صلى الله عليه وسلم";
        bottomPanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_2()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        sidePanelText.arabicText = " خوف الروم \n\n من قيام الدولة \n\n الإسلامية الحديثة ";
        sidePanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_3()
    {
        Time.timeScale = 0.1f;

        bottomPanelText.arabicText = "هرب الجيش الروماني";
        bottomPanelText.SetArabText();

        timelineSlider.value = 0.5f;
        currentTime.arabicText = "رجب \n 15";
        currentTime.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_4()
    {
        Time.timeScale = 0.1f;

        bottomPanelText.arabicText = "معجزة الآبار";
        bottomPanelText.SetArabText();

        yield return new WaitForSeconds(startTimescaleDelay);

        for (int i = 1; i <= 15; i++)
        {
            //Debug.Log("timeline: " + (i * 10 / 30) + 
            //    "\nround: " + ((i * 10 / 30) * 0.1f));

            timelineSlider.value = ((i * 10 / 30) * 0.1f);
            currentTime.arabicText = "رجب \n " + i.ToString();
            currentTime.SetArabText();

            yield return new WaitForSeconds(timescaleDelay);
        }
    }
    IEnumerator PlayClip_5()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 15";
        currentTime.SetArabText();

        bottomPanelText.arabicText = "توزع الجيش";
        bottomPanelText.SetArabText();

        armyArrangementTextField.arabicText = "اللواء الأعظم : أبوبكر الصديق" +
            "\nالراية العظمى : الزبير بن العوام" +
            "\nراية الأوس : أسيد بن خضير" +
            "\nراية الخزرج : أبو دجانة" +
            "\nراية بني مالك : زيد بن ثابت";
        armyArrangementTextField.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_6()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "شعبان \n 1";
        currentTime.SetArabText();

        bottomPanelText.arabicText = "السرايا التي \nبعثها النبي من تبوك";
        bottomPanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_7()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "شعبان \n 1";
        currentTime.SetArabText();

        sidePanelText.arabicText = " - حكم صلاة المسافر \n\n - خطبة النبي \n صلى الله عليه وسلم \n\n - معجزات النبي \n صلى الله عليه وسلم ";
        sidePanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
}
