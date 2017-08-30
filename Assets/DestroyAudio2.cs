using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyAudio2 : MonoBehaviour {

    public string sceneName;

    void Start()
    {
        StartCoroutine(waitAndChangeScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waitAndChangeScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(sceneName);
    }
}
