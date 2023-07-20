using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup_down : MonoBehaviour
{
    public GameObject panel;
    public GameObject Popup;
    
    public void OnClick()
    {
        panel.SetActive(false);
        Popup.SetActive(false);
    }
}
