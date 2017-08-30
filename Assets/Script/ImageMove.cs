using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMove : MonoBehaviour
{
    private const float BATAS_KIRI = 0;
    private const float BATAS_KANAN = -884f;
    private const float SPEEDX = 300;

    private bool isMove;
    private bool isRight;

    private Vector3 positon;

    private RectTransform rectTransform;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();

        positon = rectTransform.anchoredPosition;
    }

    void Update()
    {
        if (isMove)
        {
            if (isRight)
            {
                positon.x += SPEEDX * Time.deltaTime;
                if (positon.x >= BATAS_KIRI)
                {
                    positon.x = BATAS_KIRI;
                }
            }
            else
            {
                positon.x -= SPEEDX * Time.deltaTime;
                if (positon.x <= BATAS_KANAN)
                {
                    positon.x = BATAS_KANAN;
                }
            }

            rectTransform.anchoredPosition = positon;
        }
    }

    public void move(bool isRight)
    {
        isMove = true;
        this.isRight = isRight;
    }

    public void stopMove()
    {
        isMove = false;
    }
}
