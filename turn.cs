using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour // 턴교차
{
    public GameObject[] enemy = new GameObject[5];
    public int totalenemyAttack=0;
    public GameObject[] stop = new GameObject[7];
    private bool isturn = true;
    // Start is called before the first frame update
    void Awake() // 시작할때 움직일 수 있게 설정
    {
        for(int i=0; i<7; i++){
        stop[i].GetComponent<moveblock>().enabled=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isturn){ // isturn이 참이면 실행
            if(Timer.timer<=0){ // 타이머가 0초가 되면 멈춤
                for(int i=0; i<7; i++){
                    stop[i].GetComponent<moveblock>().enabled=false;
                }
                isturn = !isturn; // false로 전환
            }
        }
        else if(!isturn){ // false 로 전환된게 true면 실행
            if(totalenemyAttack==0){ // 적의 공격이 모두 끝나면 실행
                Timer.timer=10; // 타이머 시간 추가
                Timer.timerIsRunning =true; // 시간 흐르게 하기
                bag.clone.GetComponent<moveblock>().enabled=true;      // |
                for(int i=0; i<7; i++){                                // | 다시 움직일 수 있게 설정
                    stop[i].GetComponent<moveblock>().enabled=true;    // |
                }
                isturn = !isturn; // true로 전환
            }
        }
    }
}
