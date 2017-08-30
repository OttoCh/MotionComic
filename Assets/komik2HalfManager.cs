using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class komik2HalfManager : MonoBehaviour {

    public GameObject halaman10;
    public GameObject halaman11;
    public GameObject halaman12;
    public GameObject halaman13;
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
                    halaman10.SetActive(false);
                    halaman11.SetActive(true);
                }
                else if (index == 2)
                {
                    StartCoroutine(startFadeObject(black));
                }
                else if (index == 3)
                {
                    halaman11.SetActive(false);
                    halaman12.SetActive(true);
                }
                else if (index == 4)
                {
                    halaman12.SetActive(false);
                    halaman13.SetActive(true);
                }
                else if(index >= 5)
                {
                    SceneManager.LoadScene("endChap1");
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
            alpha -= 0.2f;
            yield return new WaitForSeconds(0.1f);
            image.color = new Color(0.0f, 0.0f, 0.0f, alpha);
        }
        target.SetActive(false);
        image.color = new Color(0.0f, 0.0f, 0.0f, 1);
    }
    
    IEnumerator waitUntilNextClick()
    {
        yield return new WaitForSeconds(0.5f);
        getClick = false;
    }

    public void changeIndex(int numb)
    {
        if (!getClick)
        {
            /*
            if (Input.GetMouseButtonDown(0))
            {
                getClick = true;
                index += numb;
                if (index == 0)
                {
                    halaman10.SetActive(true);
                    halaman11.SetActive(false);
                }
                else if (index == 1)
                {
                    halaman10.SetActive(false);
                    halaman11.SetActive(true);
                    black.SetActive(true);
                }
                else if (index == 2)
                {
                    halaman11.SetActive(true);
                    StartCoroutine(startFadeObject(black));
                    halaman12.SetActive(false);
                }
                else if (index == 3)
                {
                    halaman11.SetActive(false);
                    halaman12.SetActive(true);
                    halaman13.SetActive(false);
                }
                else if (index == 4)
                {
                    halaman12.SetActive(false);
                    halaman13.SetActive(true);
                }
                else if (index >= 5)
                {
                    SceneManager.LoadScene("endChap1");
                }
                StartCoroutine(waitUntilNextClick());
            }
            */
        }
    }
}
