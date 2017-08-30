using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gotoJawa();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gotoRomusha();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            gotoKomik2();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            gotoBelandaFlag();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            gotoKuis();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            gotoKomik3();
        }
    }

    public void gotoGaleri()
    {
        SceneManager.LoadScene("galeri");
    }

    public void gotoKomik()
    {
        SceneManager.LoadScene("beginChap1");
    }

    public void gotoJawa()
    {
        SceneManager.LoadScene("jawa");
    }

    public void gotoKuis()
    {
        SceneManager.LoadScene("kuis");
    }

    public void gotoKomik2()
    {
        SceneManager.LoadScene("komik 2");
    }

    public void gotoBelandaFlag()
    {
        SceneManager.LoadScene("belanda flag");
    }

    public void gotoRomusha()
    {
        SceneManager.LoadScene("romusha");
    }

    public void gotoKomik3()
    {
        SceneManager.LoadScene("beginChap2");
    }

}
