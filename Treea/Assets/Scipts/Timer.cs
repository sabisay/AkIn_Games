using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float currentTime;
    private bool isTimeRunning = false;
    public GameObject Buttons;
    public TMP_Text timerText;

    // Use Start method for initialization
    void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        if (isTimeRunning == true)
        {
            currentTime += Time.deltaTime;

            UpdateTimerUI();
        }
    }

    void UpdateTimerUI()
    {
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        isTimeRunning = true;
    }

}
