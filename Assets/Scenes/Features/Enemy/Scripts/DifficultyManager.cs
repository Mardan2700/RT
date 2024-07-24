using System.Collections;
using System.Collections.Generic;
using Scenes.Features.Enemy.Scripts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyManager : MonoBehaviour
{

    public Difficulty difficulty;
    
    
    public TMP_Dropdown difficultyValues;
    
    
    public void Start()
    {
        difficultyValues.onValueChanged.AddListener((value) => OnDrop(value));
    }


    private void OnDrop(int value)
    {
        switch (value)
        {
            case 0: difficulty.SetValues(DifficultyLevel.Easy, 25, 2);
                break;
            case 1: difficulty.SetValues(DifficultyLevel.Medium, 30, 1);
                break;
            case 2: difficulty.SetValues(DifficultyLevel.Hard, 35, 0.8f);
                break;
        }
    }
    
    
}
