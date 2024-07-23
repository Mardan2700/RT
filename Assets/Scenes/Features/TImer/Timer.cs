using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer = 0.0f;
    public TMP_Text timerText; // Referenz zum Text-Element im UI

    void Start()
    {
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = "Timer: " + timer.ToString("F2") + " Sekunden";
    }
}