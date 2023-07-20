using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_apear : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    private void Start()
    {
        Text1.SetActive(true);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
    }
    public void OnClick()
    {
        Text1.SetActive(true);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(false);
    }
}
