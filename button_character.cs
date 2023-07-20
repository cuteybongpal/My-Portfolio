using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_character : MonoBehaviour
{
    public GameObject info1;
    public GameObject info2;
    public GameObject info3;
    public GameObject info4;
    public GameObject info5;
    
    public void OnClickinfo1()
    {
        info1.SetActive(true);
        info2.SetActive(false);
        info3.SetActive(false);
        info4.SetActive(false);
        info5.SetActive(false);
    }
    public void OnClickinfo2()
    {
        info1.SetActive(false);
        info2.SetActive(true);
        info3.SetActive(false);
        info4.SetActive(false);
        info5.SetActive(false);
    }
    public void OnClickinfo3()
    {
        info1.SetActive(false);
        info2.SetActive(false);
        info3.SetActive(true);
        info4.SetActive(false);
        info5.SetActive(false);
    }
    public void OnClickinfo4()
    {
        info1.SetActive(false);
        info2.SetActive(false);
        info3.SetActive(false);
        info4.SetActive(true);
        info5.SetActive(false);
    }
    public void OnClickinfo5()
    {
        info1.SetActive(false);
        info2.SetActive(false);
        info3.SetActive(false);
        info4.SetActive(false);
        info5.SetActive(true);
    }
    public void OnClick1()
    {
        SceneManager.LoadScene("character1");
    }
    public void OnClick2()
    {
        SceneManager.LoadScene("character2");
    }
    public void OnClick3()
    {
        SceneManager.LoadScene("character3");
    }
    public void OnClick4()
    {
        SceneManager.LoadScene("character4");
    }
    public void OnClick5()
    {
        SceneManager.LoadScene("character5");
    }
}
