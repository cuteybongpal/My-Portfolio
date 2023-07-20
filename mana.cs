using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mana : MonoBehaviour
{
    private Text mnText;
    [SerializeField] // private 변수슷 인스펙터에서 접근할 수 있게 해주는 기능
    private Slider mana1;
    private int maxmana=100;

    // Start is called before the first frame update
    void Start()
    {
        moveblock.curmana=0; // 마나를 0으로 초기화
        mnText=GameObject.Find("manaText").GetComponent<Text>(); //텍스트 컴포넌트 접근
    }

    // Update is called once per frame
    private void Update()
    {
        mana1.value = Mathf.RoundToInt(moveblock.curmana); // 현재마나 계산
        text(); // 텍스트 출력
    }
    void text(){
        mnText.text=Mathf.RoundToInt(moveblock.curmana) + "/" + maxmana;
    }
}
