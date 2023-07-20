using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickpet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dg;
    public GameObject equiment;
    public GameObject prey;

    public void OnClick()
    {
        dg.SetActive(false);
        equiment.SetActive(false);
        prey.SetActive(true);
    }
}
