using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_quest : MonoBehaviour
{
    public GameObject dailyquest;
    public GameObject weeklyquest;
    public GameObject mainquest;

    public void OnClick()
    {
        dailyquest.SetActive(false);
        weeklyquest.SetActive(false);
        mainquest.SetActive(true);
    }
}