using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public Score scoreData; 
    public TMP_Text scoreText; 

    void Update()
    {
        scoreText.text = "Score: " + scoreData.score;
    }
}
