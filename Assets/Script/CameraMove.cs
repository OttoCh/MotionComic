using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private const float BATAS_KIRI = -16.87f;
    private const float BATAS_KANAN = 17.3f;
    private const float SPEEDX = 5;

    private bool isMove;
    private bool isRight;    

    private Vector3 positon;
    
    void Awake()
    {
        positon = transform.position;
    }
    
    void Update()
    {
        if(isMove)
        {
            if(isRight)
            {
                positon.x += SPEEDX * Time.deltaTime;
                if(positon.x >= BATAS_KANAN)
                {
                    positon.x = BATAS_KANAN;
                }
            }
            else
            {
                positon.x -= SPEEDX * Time.deltaTime;
                if (positon.x <= BATAS_KIRI)
                {
                    positon.x = BATAS_KIRI;
                }
            }

            transform.position = positon;
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
