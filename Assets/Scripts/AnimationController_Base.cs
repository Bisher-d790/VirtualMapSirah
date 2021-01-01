using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController_Base : MonoBehaviour
{
    [SerializeField] private int clip;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetInteger("Clip", clip);

        StartCoroutine("PlayClip_" + clip);
    }
}
