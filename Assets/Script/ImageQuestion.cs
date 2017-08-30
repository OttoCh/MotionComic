using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageQuestion : MonoBehaviour
{
    public Sprite[] spr;

    private int indexSprite;

    private Image image;
    
    void Awake()
    {
        image = GetComponent<Image>();
    }
    
    public void updateImage()
    {
        image.sprite = spr[indexSprite];
        indexSprite++;
    }
}
