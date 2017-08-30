using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class BtnQuiz : MonoBehaviour, IPointerClickHandler
{
    public int indexAnswer;

    public Text txtAnswer;

    void Awake()
    {
        
    }

    public void setText(string str)
    {
        txtAnswer.text = str;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        QuizManager.instance.checkJawaban(indexAnswer);
    }
}
