using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class totalTimer : MonoBehaviour // 총 시간
{
    public float totaltimer = 540;
    public bool totaltimerIsRunning = false;
    public Text totaltimeText;
    private void Start()
    {
        // Starts the timer automatically
        totaltimerIsRunning = true; // 시간 흐르게 하기
    }
    void Update()
    {
        if (totaltimerIsRunning)
        {
            if (totaltimer > 0) // 타이머가 0초가 안되면 실행
            {
                totaltimer -= Time.deltaTime;
                DisplayTime(totaltimer);
            }
            else // 타이머가 0초가 되면 실행
            {
                totaltimer = 0;
                totaltimerIsRunning = false; // 시간을 멈추게 하기
            }
        }
    }
    void DisplayTime(float totaltimeToDisplay)
    {
        totaltimeToDisplay += 1;
        float totalminutes = Mathf.FloorToInt(totaltimeToDisplay / 60); // 시간을 분으로 전환
        float totalseconds = Mathf.FloorToInt(totaltimeToDisplay % 60); // 시간을 초로 변환
        totaltimeText.text = string.Format("{0:00}:{1:00}", totalminutes, totalseconds); // 시간을 텍스트로 표시
    }
}