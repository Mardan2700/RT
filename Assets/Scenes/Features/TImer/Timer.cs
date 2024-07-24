using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timer = 10; // Initialisiere den Timer mit 3 Sekunden
    public TMP_Text timerText; // Referenz zum Text-Element im UI
    public GameManagerScript gameManager;
    private bool isDead;
   
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0) 
            {
                timer = 0;
            }
        }
        
        timerText.text = "Timer: " + timer.ToString("F2") + " Sekunden";

        if (timer <= 0 && !isDead)
        {
            isDead = true;
            SceneManager.LoadScene("GameOverSceen");
            Debug.Log("dead");
        }
    }
}