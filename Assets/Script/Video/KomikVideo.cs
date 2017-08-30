using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class KomikVideo : MonoBehaviour
{
    public string nextScene;

    public VideoClip[] videoClips;

    public SpriteRenderer black;

    private bool isPlayingMovie = true;
    private bool isFadeIn;

    private Color color;

    private float videoTimer;

    public int indexVideo;
    private int maksIndeksVideo;    

    private VideoPlayer videoPlayer;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();

        color = black.color;
        color.a = 0;

        maksIndeksVideo = videoClips.Length;
    }
    
    void Update()
    {
        if (isPlayingMovie)
        {
            if (!videoPlayer.isPlaying)
            {
                videoTimer += Time.deltaTime;
                if (videoTimer >= 0.5f)
                {
                    videoTimer = 0;
                    isPlayingMovie = false;
                    isFadeIn = true;
                    videoPlayer.Stop();
                    indexVideo++;
                }
            }
        }
        else 
        {
            if (isFadeIn)
            {
                color.a += Time.deltaTime;
                if (color.a >= 1)
                {
                    isFadeIn = false;
                    color.a = 1;

                    if (indexVideo < maksIndeksVideo)
                    {
                        setVideo(videoClips[indexVideo]);
                        videoPlayer.Play();
                    }
                    else
                    {
                        SceneManager.LoadScene(nextScene);
                    }
                }
            }
            else
            {
                color.a -= Time.deltaTime;
                if (color.a < 0)
                {
                    isPlayingMovie = true;
                    isFadeIn = false;
                    color.a = 0; 
                }
            }

            black.color = color;
        }
    }

    public void setVideo(VideoClip video)
    {
        videoPlayer.clip = video;
    }
}
