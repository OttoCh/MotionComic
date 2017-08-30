using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MainMenuVideo : MonoBehaviour
{
    public BtnTitle btnKomik;
    public BtnTitle btnGaleri;

    private VideoPlayer videoPlayer;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.Play();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (videoPlayer.time < 17)
            {
                videoPlayer.time = 17;
                btnKomik.forceShow();
                btnGaleri.forceShow();
            }
        }
    }
}
