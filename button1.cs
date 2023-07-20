using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class button1 : MonoBehaviour
{
    public GameObject Popup;

    void Start()
    {
        Popup.SetActive(false);
    }
    public void OnClick()
    {
        Popup.SetActive(true);
    }
    
}
