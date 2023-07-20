using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDraw : MonoBehaviour
{
    
        // 활성화,비활성화 할 오브젝트

        public static GameObject DrawShop; // 뽑기 상점
        public static GameObject DrawWindow; // 뽑는 창

        // 불러올 이미지 오브젝트
        public static Image DrawImage; // 랜덤 이미지를 출력할 오브젝트

        //숫자 이미지
        public static Sprite Image1;
        public static Sprite Image2;
        public static Sprite Image3;

        // 변수
        public static int RandomInt; // 랜덤 변수
        public bool OnOff = false; // True이면 뽑기 이미지 활성화 False면 뽑기 이미지 비활성화
        public float Timer; // 시간 오차 없게 하기 위해 타이머 선언
    void Start()
    {
        // 오브젝트 불러오기

        DrawShop = GameObject.Find("Canvas").transform.Find("DrawShop").gameObject; // 활성화되어있는 오브젝트들을 우선적으로 
        DrawWindow = GameObject.Find("Canvas").transform.Find("DrawWindow").gameObject;
        DrawImage = GameObject.Find("Canvas").transform.Find("DrawWindow").transform.Find("Image").gameObject.GetComponent<Image>();

        // Sprite 이미지 불러오기
        Image1 = Resources.Load<Sprite>("Image/One"); // Asset폴더 내에 Resources폴더를 만들어 이미지를 폴더 안에 넣어야 합니다.
        Image2 = Resources.Load<Sprite>("Image/Two"); // Resource 폴더 내 경로대로 작성해주어야 합니다.
        Image3 = Resources.Load<Sprite>("Image/Three");
    }
        void Update()
        {
            RandomInt = Random.Range(1, 4);

            if (OnOff == true)
            {
                Timer += Time.deltaTime; // 타이머 활성화
                DrawShop.SetActive(false); // 뽑기 선택 화면을 비활성화하고,
                DrawWindow.SetActive(true); // 이미지 출력 화면을 활성화합니다.
                if (Timer >= 2.0f) // Timer가 2를 넘었을 때
                {
                    CloseDraw(); // CloseDraw를 출력합니다.
                }
            }
            else // OnOff 가 False 라면
            {
                DrawShop.SetActive(true); // 뽑기 선택 화면을 활성화하고,
                DrawWindow.SetActive(false); // 이미지 출력 화면을 비활성화합니다.
                Timer = 0; // 타이머는 0으로 설정합니다.
            }
        }

        public void OneDraw() // 1회 뽑기를 선택한다면 실행하는 함수
        {

            OnOff = true; // Onoff를 True로 바꿉니다.

            if (RandomInt == 1)
            {
                DrawImage.sprite = Image1;
            }
            else if (RandomInt == 2)
            {
                DrawImage.sprite = Image2;
            }
            else if (RandomInt == 3)
            {
                DrawImage.sprite = Image3;
            }

        }

        public void CloseDraw() // 뽑기가 실행이 되면 자동으로 실행이 됩니다.
        {
            DrawImage.sprite = null; // 출력한 이미지를 초기화합니다.
            OnOff = false; // OnOff를 false로 바꿉니다.
        }
}