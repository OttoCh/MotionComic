using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class JavaEventManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public ImgDaerahJava imgDaerahJava;

    public BtnIconLokasi btnIconLokasi0;
    public BtnIconLokasi btnIconLokasi1;
    public BtnIconLokasi btnIconLokasi2;

    private bool isPlay = true;

    private int indexPlay;

    private float videoTimer;

    public GameObject text11;
    public GameObject text12;

    private bool alreadyShow1 = false;
    private bool alreadyShow2 = false;

    public GameObject image;

    void Awake()
    {

    }

    void Update()
    {
        if (isPlay)
            videoTimer += Time.deltaTime;

        if (indexPlay == 0)
        {
            if (videoTimer >= 10)
            {
                videoPlayer.Pause();
                indexPlay++;
            }
        }
        else if (indexPlay == 1)
        {
            if (videoTimer >= 13.75f)
            {
                isPlay = false;
                if (!alreadyShow1)
                {
                    StartCoroutine(startShowObject(text11));
                    alreadyShow1 = true;
                }
                btnIconLokasi0.startScaleLoop();
            }
        }
        else if (indexPlay == 2)
        {
            if (videoTimer >= 14.75f)
            {
                isPlay = false;
                btnIconLokasi1.startScaleLoop();
            }
        }
        else if (indexPlay == 3)
        {
            if (videoTimer >= 15.75f)
            {
                isPlay = false;
                btnIconLokasi2.startScaleLoop();
            }
        }
        else if (indexPlay == 4)
        {
            if (videoTimer >= 16.75f)
            {
                if (!alreadyShow2)
                {
                    StartCoroutine(startShowObject(text12));
                    alreadyShow2 = true;
                }
                imgDaerahJava.hide();
                indexPlay++;
            }
        }
        else if (indexPlay == 5)
        {
            if (videoTimer >= 17.75f)
            {
                image.SetActive(false);
                isPlay = false;
                videoPlayer.time = 14;
                videoPlayer.Play();
                indexPlay++;
            }
        }
        else if(videoPlayer.time >= 22)
        {
            SceneManager.LoadScene("romusha");
        }
    }

    public void nextCity()
    {
        isPlay = true;
        indexPlay++;
    }

    IEnumerator startShowObject(GameObject target)
    {
        target.SetActive(true);
        Image image = target.GetComponent<Image>();
        float alpha = 0.0f;
        image.color = new Color(1f, 1f, 1f, alpha);
        while (alpha < 1.0f)
        {
            alpha += 0.1f;
            yield return new WaitForSeconds(0.1f);
            image.color = new Color(1f, 1f, 1f, alpha);
        }
    }
}
