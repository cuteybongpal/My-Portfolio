using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//1ȸ �̱�� ������ �����ص�ȴ� ���ϰ� �Ȱ��� �۵��մϴ�.

//10ȸ �̱⵵ �Ȱ��� �۵��մϴ�.

public class R : MonoBehaviour
{
    //������ ������Ʈ
    public static GameObject DrawShop; //��� ȭ��
    public static GameObject DrawWindow; // �̱� ȭ��
    public static GameObject OneDrawIMG; // 1ȸ �̱� ��� ȭ��
    public static GameObject TenDrawIMG; // 10ȸ �̱� ��� ȭ��
    public static GameObject TenIMG; // 10ȸ �̱� ���Ե�

    //���� �̹���
    public static Sprite[] Spr; //Sprite �̹��� ����

    // ����
    public int RandomInt; // ���� ����

    public int DrawCount; // �̱� ī��Ʈ
    public bool TimeSet; // Ÿ�̸� Ȱ��ȭ ����
    public float Timer; // Ÿ�̸�
    public int Slotindex; // ���� �ε���(0���� ����)
    public int ChangeInt; // RandomInt�� �����ϴ� ����

    void Start()
    {
        // ������Ʈ �ҷ�����

        DrawShop = GameObject.Find("Canvas").transform.Find("DrawShop").gameObject; //DrawShop�� Canvas�ȿ� �ִ� DrawShop ��� �̸��� ������Ʈ�Դϴ�.
        DrawWindow = GameObject.Find("Canvas").transform.Find("DrawWindow").gameObject;
        OneDrawIMG = GameObject.Find("Canvas").transform.Find("DrawWindow").transform.Find("OneImage").gameObject;
        TenDrawIMG = GameObject.Find("Canvas").transform.Find("DrawWindow").transform.Find("TenImage").gameObject;

        // ����ȭ�� ����ϱ�
        DrawShop.SetActive(true);
        DrawWindow.SetActive(false);
        OneDrawIMG.SetActive(false);
        TenDrawIMG.SetActive(false);

        // Sprite �̹��� �ҷ�����
        Spr = Resources.LoadAll<Sprite>("Image"); // Asset���� ���� Resources������ ����� �̹����� ���� �ȿ� �־�� �մϴ�.
        // Resource ���� �� ��δ�� �ۼ����־�� �մϴ�.

        DrawCount = 0; // �̱� ī��Ʈ�� 0�� �ʱ�ȭ
        Timer = 0;   // Ÿ���͵� �ʱ�ȭ
    }

    void Update()
    {
        TenIMG = GameObject.Find("Canvas").transform.Find("DrawWindow").transform.Find("TenImage").gameObject.transform.GetChild(Slotindex).gameObject;

        RandomInt = Random.Range(1, 4); // RandomInt�� ������ 0 ~ 9

        if (TimeSet == true)
        {
            Timer += Time.deltaTime;
        }
        else //Timeset�� ����Ǿ��ٸ�
        {
            if (Slotindex > 0) // �����ε����� 0 �̻��̶��
            {
                Timer += Time.deltaTime; //Ÿ�̸� �۵�
                if (Timer > 0.1f)
                {
                    for (; Slotindex > 0; Slotindex--)
                    {
                        TenIMG.gameObject.transform.GetComponent<Image>().sprite = null;
                        Debug.Log(Slotindex);
                        Timer = 0;
                        break;
                    }
                    Slotindex -= 1;
                }
            }
            TenIMG.gameObject.transform.GetComponent<Image>().sprite = null;
        }
    }
    public void OneDraw() // 1ȸ �̱⸦ �����Ѵٸ� �����ϴ� �Լ�
    {
        Debug.Log("1ȸ �̱�");
        DrawShop.SetActive(false);
        DrawWindow.SetActive(true);
        OneDrawIMG.SetActive(true);
        ChangeInt = RandomInt; // ChangeInt ������ RandomInt�� ����
        OneDrawIMG.gameObject.transform.GetComponent<Image>().sprite = Spr[ChangeInt];
        Invoke("CloseDraw", 2.0f);
    }
    public void TenDraw()// 10ȸ �̱� ����
    {
        TimeSet = true;
        DrawShop.SetActive(false);
        DrawWindow.SetActive(true);
        TenDrawIMG.SetActive(true);

        if (DrawCount == 10)
        {
            DrawCount = 0;
            Invoke("CloseDraw", 3.0f);
        }
        else
        {
            if (Timer >= 2.0f)
            {
                ChangeInt = RandomInt;

                TenIMG.gameObject.transform.GetComponent<Image>().sprite = Spr[ChangeInt];
                Timer = 0;
                DrawCount += 1;
            }
            if (DrawCount < 10)
            {
                Slotindex = DrawCount;
            }
            Invoke("TenDraw", 0f);// TenDraw �Լ��� �ٷ� �����Ѵ�.
        }
    }
    public void CloseDraw() // �׸��� �ݴ´�.
    {
        DrawShop.SetActive(true);
        DrawWindow.SetActive(false);
        OneDrawIMG.SetActive(false);
        TenDrawIMG.SetActive(false);
        TimeSet = false;
        Debug.Log("�̱� ����");
        OneDrawIMG.gameObject.transform.GetComponent<Image>().sprite = null;
    }
}
