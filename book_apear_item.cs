using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_apear_item : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    public void OnClick()
    {
        Text1.SetActive(false);
        Text2.SetActive(true);
        Text3.SetActive(false);
        Text4.SetActive(false);
    }
}
