using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "ScriptableObjects/ScoreData", order = 1)]
public class Score : ScriptableObject
{
    public int score;

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("score: "+score);
    }
    public void Reset()
    {
        score = 0;
    }
}
