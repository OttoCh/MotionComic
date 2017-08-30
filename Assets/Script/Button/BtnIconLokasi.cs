using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnIconLokasi : MonoBehaviour
{
    public float maksTimerShow;

    private bool isShow = true;
    private bool isAnimate;

    private float timerShow;

    private RectTransform rectTransform;
    private Image image;
    private Animator animator;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();

        image.raycastTarget = false;
    }
    
    void Update()
    {
        if (isShow)
        {
            timerShow += Time.deltaTime;
            if (timerShow >= maksTimerShow)
            {
                isShow = false;
                isAnimate = true;
                animator.SetInteger("INDEX",1);
            }
        }
    }

    public void startScaleLoop()
    {
        animator.SetInteger("INDEX", 2);
        image.raycastTarget = true;
    }

    public void stopLoop()
    {
        animator.enabled = false;
        rectTransform.localScale = new Vector3(1, 1, 1);
        image.raycastTarget = false;
    }
}
