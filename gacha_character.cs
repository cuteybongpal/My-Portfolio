using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gacha_character : MonoBehaviour
{
    public GameObject character;
    public GameObject equipment;
    public GameObject pet_skin;

    public void OnClick()
    {
        character.SetActive(true);
        equipment.SetActive(false);
        pet_skin.SetActive(false);
    }
    private void Start()
    {
        character.SetActive(true);
        equipment.SetActive(false);
        pet_skin.SetActive(false);
    }
}
