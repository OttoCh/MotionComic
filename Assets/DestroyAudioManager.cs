using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyAudioManager : MonoBehaviour {

    public string sceneName;

	// Use this for initialization
	void Start () {
        GameObject audio = GameObject.Find("Audio Source").gameObject;
        if(audio != null) Destroy(audio);
        StartCoroutine(waitAndChangeScene());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator waitAndChangeScene()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(sceneName);
    }
}
