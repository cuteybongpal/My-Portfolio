using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour // 테르리스 시간
{
    public static float timer = 30f;
    public static bool timerIsRunning = false;
    public Text timeText;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true; // 시간 흐르게 하기
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timer > 0) // 타이머가 0초가 안되면 실행
            {
                timer -= Time.deltaTime;
                DisplayTime(timer);
            }
            else // 타이머가 0초가 되면 실행
            {
                timerIsRunning = false; // 시간을 멈추게 하기
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // 시간을 분으로 전환
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // 시간을 초로 변환
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // 시간을 텍스트로 표시
    }
}

