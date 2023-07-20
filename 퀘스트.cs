using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 퀘스트 : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChanage()
    {
        SceneManager.LoadScene("퀘스트");
    }

}