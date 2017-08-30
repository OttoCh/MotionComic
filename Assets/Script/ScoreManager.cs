using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text txtScore;

    private int currentScore;
    
    void Awake()
    {

    }

    public void increaseScore()
    {
        currentScore++;
        txtScore.text = currentScore + "/10";
    }
}
