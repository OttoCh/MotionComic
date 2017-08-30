using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Komik2Manager : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public float timeText1;
    public float timeText2;
    public float timeText3;
    public float timeText4;
    public float timeText5;
    public float timeText6;

    public GameObject text31;
    public GameObject text32;
    public GameObject text33;
    public GameObject text34;
    public GameObject text35;

    private bool alreadyShow31 = false;
    private bool alreadyShow32 = false;
    private bool alreadyShow33 = false;
    private bool alreadyShow34 = false;
    private bool alreadyShow35 = false;

    KomikVideo km;

    // Use this for initialization
    void Start () {
        km = videoPlayer.GetComponent<KomikVideo>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(videoPlayer.time);
        if (videoPlayer.time >= timeText1 && videoPlayer.time <= timeText1 + 1.0f && km.indexVideo == 0)
        {
            if (!alreadyShow31)
            {
                StartCoroutine(startShowObject(text31));
                alreadyShow31 = true;
            }
        }
        else if (videoPlayer.time >= timeText2 && videoPlayer.time <= timeText2 + 1.0f && km.indexVideo == 1)
        {
            if (!alreadyShow32)
            {
                StartCoroutine(startFadeObject(text31));
                StartCoroutine(startShowObject(text32));
                alreadyShow32 = true;
            }
        }
        else if (videoPlayer.time >= timeText3 && videoPlayer.time <= timeText3 + 1.0f && km.indexVideo == 2)
        {
            if (!alreadyShow33)
            {
                StartCoroutine(startFadeObject(text32));
                StartCoroutine(startShowObject(text33));
                alreadyShow33 = true;
            }
        }
        else if (videoPlayer.time >= timeText4 && videoPlayer.time <= timeText4 + 1.0f && km.indexVideo == 2)
        {
            if (!alreadyShow34)
            {
                StartCoroutine(startShowObject(text34));
                alreadyShow34 = true;
            }
        }
        else if (videoPlayer.time >= timeText5 && videoPlayer.time <= timeText5 + 1.0f && km.indexVideo == 3)
        {
            if (!alreadyShow35)
            {
                StartCoroutine(startFadeObject(text33));
                StartCoroutine(startFadeObject(text34));
                StartCoroutine(startShowObject(text35));
                alreadyShow35 = true;
            }
        }
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

    IEnumerator startFadeObject(GameObject target)
    {
        Image image = target.GetComponent<Image>();
        float alpha = 1.0f;
        image.color = new Color(1f, 1f, 1f, alpha);
        while (alpha > 0.0f)
        {
            alpha -= 0.1f;
            yield return new WaitForSeconds(0.1f);
            image.color = new Color(1f, 1f, 1f, alpha);
        }
        target.SetActive(false);
    }
}
