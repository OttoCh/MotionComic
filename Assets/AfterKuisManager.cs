using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class AfterKuisManager : MonoBehaviour {

    public VideoPlayer videoPlayer;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(videoPlayer.time > 489.0)
        {
            SceneManager.LoadScene("title");
        }
	}
}
