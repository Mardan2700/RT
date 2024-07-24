using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    private float timer = 0.0f;
    public TMP_Text timerText; // Referenz zum Text-Element im UI
    public GameManagerScript gameManager;
    private bool isDead;
   

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = "Timer: " + timer.ToString("F2") + " Sekunden";
        if (timer > 3 && !isDead)
        {
            isDead = true;
            SceneManager.LoadScene(1);
            Debug.Log("dead");
        }
    }
}