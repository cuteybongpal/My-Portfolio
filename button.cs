using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick1()
    {
        SceneManager.LoadScene("pve1");
    }
    public void OnClick2()
    {
        SceneManager.LoadScene("pve2");
    }
    public void OnClick3()
    {
        SceneManager.LoadScene("pve3");
    }
    public void OnClick4()
    {
        SceneManager.LoadScene("pve4");
    }
    public void OnClickmenu()
    {
        SceneManager.LoadScene("PveMenu");
    }
    public void OnClick()
    {
        SceneManager.LoadScene("profile_character_select");
    }
}
