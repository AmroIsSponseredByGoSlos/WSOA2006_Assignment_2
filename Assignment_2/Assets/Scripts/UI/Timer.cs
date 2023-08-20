using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public int currentTime; // Changed from float to int

    [SerializeField] private float totalTime = 300f; // 5 minutes in seconds
    [SerializeField] private GameObject RestartPnl;
    
    private float countdownInterval = 1f; // Update timer every one second
    private float countdownTimer = 0f;

    void Start()
    {
        currentTime = Mathf.RoundToInt(totalTime); // Convert float totalTime to int currentTime
        UpdateTimerText();
    }

    void Update()
    {
        countdownTimer += Time.deltaTime;

        // Countdown the timer every one second
        if (countdownTimer >= countdownInterval)
        {
            countdownTimer -= countdownInterval;
            DecreaseTimer();
        }
        
    }

    void DecreaseTimer()
    {
        if (currentTime > 0)
        {
            currentTime -= 1; // Decrease by 1 second (1 whole second for int)
            UpdateTimerText();
        }

        if (currentTime == 0)
        {
            RestartPnl.SetActive(true);    
        }
    }

    void UpdateTimerText()
    {
        int minutes = currentTime / 60;
        int seconds = currentTime % 60;
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    
}
