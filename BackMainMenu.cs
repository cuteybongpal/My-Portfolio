using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMainMenu : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("MainMenu");
    } 

    public void Onclick2()
    {
        SceneManager.LoadScene("character");
    }
    public void OnClick3()
    {
        SceneManager.LoadScene("PveMenu");
    }
}
