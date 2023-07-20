using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inventory : MonoBehaviour
{
    public void Onclick1()
    {
        SceneManager.LoadScene("shop");
    }

    public void Onclick2()
    {
        SceneManager.LoadScene("book");
    }

    public void Onclick3()
    {
        SceneManager.LoadScene("quest");
    }

    public void Onclick4()
    {
        SceneManager.LoadScene("gacha");
    }

    public void Onclick5()
    {
        SceneManager.LoadScene("character");
    }
    public void Onclick6()
    {
        SceneManager.LoadScene("inventory");
    }

    public void OnClick7()
    {
        SceneManager.LoadScene("ganghwa");
    }
    public void OnClick8()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClick9()
    {
        SceneManager.LoadScene("profile");
    }
}
