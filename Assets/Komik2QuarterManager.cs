using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Komik2QuarterManager : MonoBehaviour {

    public GameObject halaman7;
    public GameObject halaman8;
    public GameObject black;

    public int index = 0;

    private bool getClick = false;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!getClick)
        {
            if (Input.GetMouseButton(0))
            {
                getClick = true;
                index += 1;
                if (index == 1)
                {
                    halaman7.SetActive(false);
                    halaman8.SetActive(true);
                }
                else if (index == 2)
                {
                    StartCoroutine(startFadeObject(black));
                }
                else if (index >= 3)
                {
                    SceneManager.LoadScene("belanda flag");
                }
                StartCoroutine(waitUntilNextClick());
            }
        }
    }

    IEnumerator startFadeObject(GameObject target)
    {
        Image image = target.GetComponent<Image>();
        float alpha = 1.0f;
        image.color = new Color(0.0f, 0.0f, 0.0f, alpha);
        while (alpha > 0.0f)
        {
            alpha -= 0.1f;
            yield return new WaitForSeconds(0.1f);
            image.color = new Color(0.0f, 0.0f, 0.0f, alpha);
        }
        target.SetActive(false);
    }

    IEnumerator waitUntilNextClick()
    {
        yield return new WaitForSeconds(1.0f);
        getClick = false;
    }
}
