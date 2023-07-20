using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mana : MonoBehaviour
{
    private Text mnText;
    [SerializeField]
    private Slider mana1;
    private int maxmana=100;

    // Start is called before the first frame update
    void Start()
    {
        moveblock.curmana=0;
        mnText=GameObject.Find("manaText").GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        mana1.value = Mathf.RoundToInt(moveblock.curmana);
        text();
    }
    void text(){
        mnText.text=Mathf.RoundToInt(moveblock.curmana) + "/" + maxmana;
    }
}
