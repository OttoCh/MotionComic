using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class Komik2QuarterF : MonoBehaviour {

    public VideoPlayer videoPlayer;
    public float timeText1;

    public GameObject text21;

    private bool alreadyShow21 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (videoPlayer.time >= timeText1 && videoPlayer.time <= timeText1 + 1.0f)
        {
            if (!alreadyShow21)
            {
                StartCoroutine(startShowObject(text21));
                alreadyShow21 = true;
            }
        }
        else if (videoPlayer.time >= 13.0f)
        {
            SceneManager.LoadScene("komik 2QuarterF2");
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
