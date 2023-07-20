using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book_appear_block : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    public void OnClick()
    {
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        Text4.SetActive(true);
    }
}
