using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pve_scene_change : MonoBehaviour
{
    public void OnClickstep1()
    {
        SceneManager.LoadScene("pve1");
    }
    public void OnClickstep2()
    {
        SceneManager.LoadScene("pve2");
    }
    public void OnClickstep3()
    {
        SceneManager.LoadScene("pve3");
    }
    public void OnClickstep4()
    {
        SceneManager.LoadScene("pve4");
    }
    public void OnClicktuto()
    {
        SceneManager.LoadScene("tutorial");
    }
}
