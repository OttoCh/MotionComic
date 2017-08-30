using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Chapter2 : MonoBehaviour
{
    public Sprite[] spr;

    public GameObject oneSpecialText;

    public Image image;
    public GameObject black;

    private int index = 0;
    private bool getClick = false;
    
    void Awake()
    {

    }
    
    void Update()
    {
        /*
        if (!getClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                getClick = true;
                if (index < 12)
                {
                    index++;
                    if (index == 0)
                    {
                        image.sprite = spr[0];
                    }
                    else if (index == 1)
                    {
                        image.sprite = spr[1];
                    }
                    else if (index == 2)
                    {
                        image.sprite = spr[2];
                        black.SetActive(true);
                    }
                    else if (index == 3)
                    {
                        image.sprite = spr[2];
                        StartCoroutine(startFadeObject(black));
                    }
                    else if (index == 4)
                    {
                        image.sprite = spr[3];
                        black.SetActive(true);
                    }
                    else if (index == 5)
                    {
                        image.sprite = spr[3];
                        StartCoroutine(startFadeObject(black));
                    }
                    else if (index == 6)
                    {
                        image.sprite = spr[4];
                    }
                    else if (index == 7)
                    {
                        image.sprite = spr[5];
                        black.SetActive(true);
                    }
                    else if (index == 8)
                    {
                        image.sprite = spr[5];
                        StartCoroutine(startFadeObject(black));
                    }
                    else if (index == 9)
                    {
                        image.sprite = spr[6];
                        black.SetActive(true);
                    }
                    else if (index == 10)
                    {
                        image.sprite = spr[6];
                        StartCoroutine(startFadeObject(black));
                    }
                    else if (index == 11)
                    {
                        //tamat
                    }
                }
                StartCoroutine(waitUntilNextClick());
            }
        }
        */
    }

    IEnumerator startFadeObject(GameObject target)
    {
        Image image = target.GetComponent<Image>();
        float alpha = 1.0f;
        image.color = new Color(0, 0, 0, alpha);
        while (alpha > 0.0f)
        {
            alpha -= 0.25f;
            yield return new WaitForSeconds(0.1f);
            image.color = new Color(0, 0, 0, alpha);
        }
        target.SetActive(false);
        image.color = new Color(0, 0, 0, 1);
    }

    IEnumerator waitUntilNextClick()
    {
        yield return new WaitForSeconds(0.5f);
        getClick = false;
    }

    public void increaseIndex(int numb)
    {
        if (!getClick)
        {
            if (index < 13) {
                getClick = true;
                index += numb;
                changeScene();
            }
        }
    }

    public void decreaseIndex(int numb)
    {
        Debug.Log("cant");
        if (!getClick)
        {
            if (index > 0)
            {
                getClick = true;
                index -= numb;
                changeScene();
            }
        }
    }

    void changeScene()
    {
            if(index == 0)
            {
                image.sprite = spr[7];
                oneSpecialText.SetActive(true);
            }
            else if (index == 1)
            {
                oneSpecialText.SetActive(false);
                image.sprite = spr[0];
            }
            else if (index == 2)
            {
                image.sprite = spr[1];
                black.SetActive(false);
            }
            else if (index == 3)
            {
                image.sprite = spr[2];
                black.SetActive(true);
            }
            else if (index == 4)
            {
                image.sprite = spr[2];
                StartCoroutine(startFadeObject(black));
            }
            else if (index == 5)
            {
                image.sprite = spr[3];
                black.SetActive(true);
            }
            else if (index == 6)
            {
                image.sprite = spr[3];
                StartCoroutine(startFadeObject(black));
            }
            else if (index == 7)
            {
                image.sprite = spr[4];
                black.SetActive(false);
            }
            else if (index == 8)
            {
                image.sprite = spr[5];
                black.SetActive(true);
            }
            else if (index == 9)
            {
                image.sprite = spr[5];
                StartCoroutine(startFadeObject(black));
            }
            else if (index == 10)
            {
                image.sprite = spr[6];
                black.SetActive(true);
            }
            else if (index == 11)
            {
                image.sprite = spr[6];
                StartCoroutine(startFadeObject(black));
            }
            else if (index == 12)
            {
                SceneManager.LoadScene("endChap2");
            }
        StartCoroutine(waitUntilNextClick());
    }
}
