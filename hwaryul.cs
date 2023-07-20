using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hwaryul : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Popup2;

    public void OnClick()
    {
        Panel.SetActive(true);
        Popup2.SetActive(true);
    }
    public void Onclick2()
    {
        Panel.SetActive(false);
        Popup2.SetActive(false);
    }
}
