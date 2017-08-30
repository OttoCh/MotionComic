using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImgDaerahJava : MonoBehaviour
{
    public Sprite sprBanten;
    public Sprite sprJabar;
    public Sprite sprJateng;

    private Image image;
    private Animator animator;

    void Awake()
    {
        image = GetComponent<Image>();
        image.enabled = false;

        animator = GetComponent<Animator>();
    }

    public void setToBanten()
    {
        image.enabled = true;
        image.sprite = sprBanten;
        animator.SetInteger("INDEX", 1);
    }

    public void setToJabar()
    {
        image.enabled = true;
        image.sprite = sprJabar;
        animator.SetInteger("INDEX", 1);
    }

    public void setToJateng()
    {
        image.enabled = true;
        image.sprite = sprJateng;
        animator.SetInteger("INDEX", 1);
    }

    public void hide()
    {
        animator.SetInteger("INDEX", 2);
    }

    public void animInit()
    {
        animator.SetInteger("INDEX", 0);
    }
}
