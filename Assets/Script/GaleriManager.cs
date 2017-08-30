using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GaleriManager : MonoBehaviour
{
    public Btn btnNext;
    public Btn btnPrev;
    public Btn btnClose;

    public Image bgBlack;

    public GameObject soundRadio;
    public AudioSource bgSound;

    public RectTransform folder;
    public RectTransform proklamasi;
    public RectTransform foto3;
    public RectTransform radio;
    public RectTransform map;
    public RectTransform file;

    void Awake()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!bgBlack.enabled)
            {
                gotoTitle();
            }
        }
        
    }

    public void gotoTitle()
    {
        SceneManager.LoadScene("title");
    }

    public void hideAll()
    {
        btnNext.setBtn(false);
        btnPrev.setBtn(false);
        btnClose.setBtn(false);
        soundRadio.SetActive(false);
        bgSound.volume = 1.0f;
        folder.anchoredPosition = new Vector3(-1000,-1000);
        proklamasi.anchoredPosition = new Vector3(-1000, -1000);
        foto3.anchoredPosition = new Vector3(-1000, -1000);
        radio.anchoredPosition = new Vector3(-1000, -1000);
        map.anchoredPosition = new Vector3(-1000, -1000);
        file.anchoredPosition = new Vector3(-1000, -1000);
        bgBlack.enabled = true;
    }

    public void close()
    {
        hideAll();
        bgBlack.enabled = false;
        btnNext.setBtn(true);
        btnPrev.setBtn(true);
        btnClose.setBtn(true);
    }
    
    public void showProklamasi()
    {
        hideAll();
        folder.anchoredPosition = new Vector3(0, 0);
        proklamasi.anchoredPosition = new Vector3(0, 0);
    }

    public void showFoto3()
    {
        hideAll();
        folder.anchoredPosition = new Vector3(0, 0);
        foto3.anchoredPosition = new Vector3(0, 0);
    }

    public void showRadio()
    {
        hideAll();
        bgSound.volume = 0.0f;
        soundRadio.SetActive(true);
        folder.anchoredPosition = new Vector3(0, 0);
        radio.anchoredPosition = new Vector3(0, 0);
    }

    public void showMap()
    {
        hideAll();
        folder.anchoredPosition = new Vector3(0, 0);
        map.anchoredPosition = new Vector3(0, 0);
    }

    public void showFile()
    {
        hideAll();
        folder.anchoredPosition = new Vector3(0, 0);
        file.anchoredPosition = new Vector3(0, 0);
    }    

}
