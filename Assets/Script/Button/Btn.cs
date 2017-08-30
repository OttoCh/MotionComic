using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    private Image image;
    private Button button;
    
    void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
    }

    public void setBtn(bool isEnbaled)
    {
        image.enabled = isEnbaled;
        button.enabled = isEnbaled;
    }
}
