using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class setting : MonoBehaviour
{
    public GameObject Popup;
    public GameObject panel;
    public GameObject Popup2;
    private void Start()
    {
        Popup.SetActive(false);
        panel.SetActive(false);
        Popup2.SetActive(false);
    }
    
    public void OnClick()
    {
        Popup.SetActive(true);
        panel.SetActive(true);
    }
}
