using System.Collections;
using System.Collections.Generic;
using Scenes.Features.Enemy.Scripts;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "DifficultySetting", menuName = "ScriptableObjects/DifficultySetting", order = 1)]
public class Difficulty : ScriptableObject
{
    
    
    
    public DifficultyLevel currentDifficulty;

    public int speed;
    public float intervall;

    
    
    
    public void SetValues(DifficultyLevel difficulty, int speed, float intervall)
    {
        this.currentDifficulty = difficulty;
        this.speed = speed;
        this.intervall = intervall;
    }
}