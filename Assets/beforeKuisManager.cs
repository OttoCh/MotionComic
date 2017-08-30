using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beforeKuisManager : MonoBehaviour {

    public Sprite[] spr;

    public Image image;

    private int index = 0;
    private bool getClick = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!getClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                getClick = true;
                index++;
                if(index == 4)
                {
                    SceneManager.LoadScene("kuis");
                }
                image.sprite = spr[index];
                StartCoroutine(waitUntilNextClick());
            }
        }
	}

    IEnumerator waitUntilNextClick()
    {
        yield return new WaitForSeconds(0.5f);
        getClick = false;
    }
}
