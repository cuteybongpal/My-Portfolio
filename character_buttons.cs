using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_buttons : MonoBehaviour
{
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
        SceneManager.LoadScene("character4");
    }
}