using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnCameraMove : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public CameraMove mainCamera;

    public bool isRight;
    
    void Awake()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mainCamera.move(isRight);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mainCamera.stopMove();
    }    
}
