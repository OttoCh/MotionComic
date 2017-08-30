using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSymbol : MonoBehaviour
{
    public Sprite sprBenar;

    private Image image;
    
    void Awake()
    {
        image = GetComponent<Image>();
    }
    
    public void setBenar()
    {
        image.sprite = sprBenar;
    }
}
