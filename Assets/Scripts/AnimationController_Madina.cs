using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController_Madina : AnimationController_Base
{
    [SerializeField] private Slider timelineSlider;
    [SerializeField] private ArabicConvert_Base currentTime;
    [SerializeField] private ArabicConvert_Base bottomPanelText;
    [SerializeField] private ArabicConvert_Base sidePanelText;

    [Header("Clip-4")]
    [SerializeField] private float startTimescaleDelay;
    [SerializeField] private float timescaleDelay;

    IEnumerator PlayClip_1()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0.8f;
        currentTime.arabicText = "جمادى الآخر \n 9هـ";
        currentTime.SetArabText();

        bottomPanelText.arabicText = "وصول خبر تجهز الروم للقتال";
        bottomPanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_2()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0f;
        currentTime.arabicText = "رجب \n 9هـ";
        currentTime.SetArabText();

        sidePanelText.arabicText = " - أمر النبي صحابته بالتجهز للغزوة \n - إخبارهم بالمقصد \n - قلة المؤونة و العسرة \n - تولية سيدنا علي المدينة \n - الأشعريون والقرآن ";
        sidePanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_3()
    {
        Time.timeScale = 0.1f;

        timelineSlider.value = 0.8f;
        currentTime.arabicText = "شعبان \n 20";
        currentTime.SetArabText();

        bottomPanelText.arabicText = " (عودة جيش النبي) \n مسجد ضرار ";
        bottomPanelText.SetArabText();

        yield return new WaitForEndOfFrame();
    }
    IEnumerator PlayClip_4()
    {
        Time.timeScale = 0.1f;
        
        timelineSlider.value = 0.8f;
        currentTime.arabicText = "شعبان \n 20";
        currentTime.SetArabText();

        sidePanelText.arabicText = " - المخلفين الثلاثة \n - اعتزال كامل \n - التوبة ";
        sidePanelText.SetArabText();

        yield return new WaitForSeconds(startTimescaleDelay);

        for (int i = 20; i <= 30; i++)
        {
            //Debug.Log("timeline: " + (i * 10 / 30) + 
            //    "\nround: " + ((i * 10 / 30) * 0.1f));

            timelineSlider.value = ((i * 10 / 30) * 0.1f);
            currentTime.arabicText = "شعبان \n " + i.ToString();
            currentTime.SetArabText();

            yield return new WaitForSeconds(timescaleDelay);
        }

        for (int i = 1; i <= 30; i++)
        {
            //Debug.Log("timeline: " + (i * 10 / 30) + 
            //    "\nround: " + ((i * 10 / 30) * 0.1f));

            timelineSlider.value = ((i * 10 / 30) * 0.1f);
            currentTime.arabicText = "رمضان \n " + i.ToString();
            currentTime.SetArabText();

            yield return new WaitForSeconds(timescaleDelay);
        }

        for (int i = 1; i <= 10; i++)
        {
            //Debug.Log("timeline: " + (i * 10 / 30) + 
            //    "\nround: " + ((i * 10 / 30) * 0.1f));

            timelineSlider.value = ((i * 10 / 30) * 0.1f);
            currentTime.arabicText = "شوال \n " + i.ToString();
            currentTime.SetArabText();

            yield return new WaitForSeconds(timescaleDelay);
        }
    }
}
