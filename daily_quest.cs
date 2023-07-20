using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daily_quest : MonoBehaviour
{
    public GameObject dailyquest;
    public GameObject weeklyquest;
    public GameObject mainquest;

    private void Start()
    {
        dailyquest.SetActive(false);
        weeklyquest.SetActive(false);
        mainquest.SetActive(true);
    }
    public void OnClick()
    {
        dailyquest.SetActive(true);
        weeklyquest.SetActive(false);
        mainquest.SetActive(false);
    }
}
