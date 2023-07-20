using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickdiamond : MonoBehaviour
{
    public GameObject dg;
    public GameObject equiment;
    public GameObject prey;

    private void Start()
    {
        dg.SetActive(true);
        equiment.SetActive(false);
        prey.SetActive(false);
    }

    public void OnClick()
    {
        dg.SetActive(true);
        equiment.SetActive(false);
        prey.SetActive(false);
    }
}
