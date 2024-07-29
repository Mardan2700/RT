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
            case 0: difficulty.SetValues(DifficultyLevel.Easy, 10, 0.9f);
                break;
            case 1: difficulty.SetValues(DifficultyLevel.Medium, 15, 0.7f );
                break;
            case 2: difficulty.SetValues(DifficultyLevel.Hard, 18, 0.5f);
                break;
        }
    }
    
    
}
