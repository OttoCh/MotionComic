using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPahlawanManager : MonoBehaviour
{
    private const float MAKS_DATA_PAHLAWAN = 6;
    private const float MAKS_DATA_INGGRIS = 2;

    public Image imgData;

    public Sprite[] sprPahlawan;
    public Sprite[] sprInggris;

    private bool isPahlawan;
    private bool isInggris;

    private int indexPahlawan;
    private int indexInggris;

    private Canvas canvas;

    void Awake()
    {
        canvas = GetComponent<Canvas>();
    }
    
    public void show()
    {
        canvas.enabled = true;
    }

    public void hide()
    {
        canvas.enabled = false;
    }


    public void showPahlawan()
    {
        isPahlawan = true;
        imgData.sprite = sprPahlawan[indexPahlawan];
    }

    public void showInggris()
    {
        isInggris = true;
        imgData.sprite = sprInggris[indexInggris];
    }

    public void setImage(bool isNext)
    {
        if (isPahlawan)
        {
            if (isNext)
            {
                indexPahlawan++;
                if (indexPahlawan == MAKS_DATA_PAHLAWAN)
                    indexPahlawan = 0;
            }
            else
            {
                indexPahlawan--;
                if (indexPahlawan == -1)
                    indexPahlawan = 5;
            }

            showPahlawan();
        }
        else if(isInggris)
        {
            if (isNext)
            {
                indexInggris++;
                if (indexInggris == MAKS_DATA_INGGRIS)
                    indexInggris = 0;
            }
            else
            {
                indexInggris--;
                if (indexInggris == -1)
                    indexInggris = 5;
            }

            showInggris();
        }
    }
}
