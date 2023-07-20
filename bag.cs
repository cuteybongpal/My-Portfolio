using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bag : MonoBehaviour
{
    public GameObject[] blockStack = new GameObject[7];
    public static GameObject clone;
    // Start is called before the first frame update
    void Start()
    {
        baag(); // 블럭 7개를 랜덤으로 소환
    }
    public void baag(){
        clone = Instantiate(blockStack[Random.Range(0,blockStack.Length)], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
