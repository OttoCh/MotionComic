using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnTitle : MonoBehaviour
{
    private Image image;
    private Button button;

    private bool isFadeIn = true;

    private float waitTimer;

    private Color color;
    
    void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();

        color = image.color;
        color.a = 0;

        image.enabled = false;
        button.enabled = false;
    }
    
    void Update()
    {
        if(!image.enabled)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer >= 7)
            {
                isFadeIn = true;
                image.enabled = true;
                image.color = color;
            }
        }
        else if(isFadeIn)
        {
            color.a += Time.deltaTime;
            if(color.a > 1)
            {
                color.a = 1;
                isFadeIn = false;
                button.enabled = true;
            }

            image.color = color;
        }
    }

    public void forceShow()
    {
        isFadeIn = false;
        color.a = 1;
        image.color = color;
        image.enabled = true;        
        button.enabled = true;
    }
    
}
