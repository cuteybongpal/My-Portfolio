using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class block : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("book");
    }
}
