using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class BelandaFlagEventManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool isHit0;
    private bool isHit1;
    private bool isHit2;
    private bool isHit3;
    

    private float videoTimer;

    private int indexPlay;
    
    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Update()
    {
        if (indexPlay == 0)
        {
            if (videoPlayer.time >= 23.5f)
            {
                videoPlayer.Pause();
                indexPlay++;
            }
        }
        else if (indexPlay == 1)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
                if (hit.collider != null)
                {
                    string nama = hit.collider.gameObject.name;
                    if (nama == "Touch Point (0)")
                    {
                        isHit0 = true;
                    }
                    else if (nama == "Touch Point (1)")
                    {
                        isHit1 = true;
                    }
                    else if (nama == "Touch Point (2)")
                    {
                        isHit2 = true;
                    }
                    else if (nama == "Touch Point (3)")
                    {
                        isHit3 = true;
                    }
                }

                if (isHit0 && isHit1 && isHit2 && isHit3)
                {
                    videoPlayer.Play();
                    indexPlay++;
                }
            }
            else if (Input.GetMouseButtonUp(0))
            {
                isHit0 = false;
                isHit1 = false;
                isHit2 = false;
                isHit3 = false;
            }
        }
        else if(!videoPlayer.isPlaying)
        {
            SceneManager.LoadScene("komik 2Half");
        }
    }
}
