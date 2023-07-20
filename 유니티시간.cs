using UnityEngine;
using System;

public class TimeExample : MonoBehaviour
{
    private void Update()
    {
        DateTime currentTime = DateTime.Now;
        Debug.Log("Current time: " + currentTime.ToString());
    }
}