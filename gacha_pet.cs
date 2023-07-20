using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gacha_pet : MonoBehaviour
{
    public GameObject character;
    public GameObject equipment;
    public GameObject pet_skin;

    public void OnClick()
    {
        character.SetActive(false);
        equipment.SetActive(false);
        pet_skin.SetActive(true);
    }
}
