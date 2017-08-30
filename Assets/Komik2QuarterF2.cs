using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class Komik2QuarterF2 : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public float timeText1;
    public float timeText2;

    public GameObject text21;
    public GameObject text22;

    private bool alreadyShow21 = false;
    private bool alreadyShow22 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(videoPlayer.time);
        if (videoPlayer.time >= timeText1 && videoPlayer.time <= timeText1 + 1.0f)
        {
            if (!alreadyShow21)
            {
                StartCoroutine(startShowObject(text21));
                alreadyShow21 = true;
            }
        }
        else if (videoPlayer.time >= timeText2 && videoPlayer.time <= timeText2 + 1.0f)
        {
            if (!alreadyShow22)
            {
                StartCoroutine(startShowObject(text22));
                alreadyShow22 = true;
            }
        }
        else if (videoPlayer.time >= 10.8f)
        {
            SceneManager.LoadScene("belanda flag");
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
            yield return new WaitForSeconds(0.2f);
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
