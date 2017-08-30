using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BtnImageMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public ImageMove imageMove;

    public bool isRight;

    void Awake()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        imageMove.move(isRight);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        imageMove.stopMove();
    }
}
