using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gacha_equipment : MonoBehaviour
{
    public GameObject character;
    public GameObject equipment;
    public GameObject pet_skin;

    public void OnClick()
    {
        character.SetActive(false);
        equipment.SetActive(true);
        pet_skin.SetActive(false);
    }
}
