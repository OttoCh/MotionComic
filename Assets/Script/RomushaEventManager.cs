using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class RomushaEventManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float timeText1;
    public float timeText2;
    public float timeText3;
    public float timeText4;

    public GameObject text21;
    public GameObject text22;
    public GameObject text23;

    private bool alreadyShow21 = false;
    private bool alreadyShow22 = false;
    private bool alreadyShow23 = false;

    void Awake()
    {

    }
    
    void Update()
    {
        if(videoPlayer.time >= timeText1 && videoPlayer.time <= timeText1+1.0f)
        {
            if (!alreadyShow21)
            {
                StartCoroutine(startShowObject(text21));
                alreadyShow21 = true;
            }
        }
        else if(videoPlayer.time >= timeText2 && videoPlayer.time <= timeText2+1.0f)
        {
            if (!alreadyShow22)
            {
                StartCoroutine(startFadeObject(text21));
                StartCoroutine(startShowObject(text22));
                alreadyShow22 = true;
            }
        }
        else if(videoPlayer.time >= timeText3 && videoPlayer.time <= timeText3+1.0f)
        {
            if(!alreadyShow23)
            {
                StartCoroutine(startFadeObject(text22));
                StartCoroutine(startShowObject(text23));
                alreadyShow23 = true;
            }
        }
        else if(videoPlayer.time >= timeText4 && videoPlayer.time <= timeText3 + 1.0f)
        {
            StartCoroutine(startFadeObject(text23));
        }
        else if(videoPlayer.time >= 37.0f)
        {
            SceneManager.LoadScene("komik 2");
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
