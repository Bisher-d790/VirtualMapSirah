using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MoviePresenterController : MonoBehaviour
{
    [SerializeField] private VideoClip[] clips;
    [SerializeField] private VideoPlayer videoPlayer;

    private int currentIndex = 0;

    private void Start()
    {
        SetClip(0);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            NextClip();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            PreviousClip();
        }
    }

    private void NextClip()
    {
        int nextIndex = currentIndex + 1 < clips.Length ? currentIndex + 1 : 0;

        SetClip(nextIndex);
    }

    private void PreviousClip()
    {
        int previousIndex = currentIndex - 1 < 0 ? clips.Length - 1 : currentIndex - 1;

        SetClip(previousIndex);
    }

    private void SetClip(int index)
    {
        currentIndex = index;
        videoPlayer.clip = clips[index];
        videoPlayer.Play();
    }
}
