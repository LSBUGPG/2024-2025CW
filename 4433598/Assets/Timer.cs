using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine;
using UnityEngine.UI;  // Make sure to import this if using Unity UI

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;  // Total time to countdown from
    public TMP_Text timerText;             // UI Text to display the timer

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  // Decrease time by the time that has passed
        }
        else
        {
            timeRemaining = 0;  // Prevent time from going negative
            // Optionally, trigger end of game here, e.g. Show "Game Over" message
        }

        // Update the timer UI
        timerText.text = "Time: " + Mathf.Round(timeRemaining).ToString();
    }
}