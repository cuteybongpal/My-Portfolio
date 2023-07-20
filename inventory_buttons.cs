using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory_buttons : MonoBehaviour
{
    public GameObject helmet;
    public GameObject armor;
    public GameObject shield;
    public GameObject shoe;
    public GameObject weapon;
    public GameObject Con;

    public void OnClickhel()
    {
        helmet.SetActive(true);
        armor.SetActive(false);
        shield.SetActive(false);
        shoe.SetActive(false);
        weapon.SetActive(false);
        Con.SetActive(false);
    }
    public void OnClickarmor()
    {
        helmet.SetActive(false);
        armor.SetActive(true);
        shield.SetActive(false);
        shoe.SetActive(false);
        weapon.SetActive(false);
        Con.SetActive(false);
    }
    public void OnClickshield()
    {
        helmet.SetActive(false);
        armor.SetActive(false);
        shield.SetActive(true);
        shoe.SetActive(false);
        weapon.SetActive(false);
        Con.SetActive(false);
    }
    public void OnClickshoe()
    {
        helmet.SetActive(false);
        armor.SetActive(false);
        shield.SetActive(false);
        shoe.SetActive(true);
        weapon.SetActive(false);
        Con.SetActive(false);
    }
    public void OnClickweapon()
    {
        helmet.SetActive(false);
        armor.SetActive(false);
        shield.SetActive(false);
        shoe.SetActive(false);
        weapon.SetActive(true);
        Con.SetActive(false);
    }
    public void OnClickCon()
    {
        helmet.SetActive(false);
        armor.SetActive(false);
        shield.SetActive(false);
        shoe.SetActive(false);
        weapon.SetActive(false);
        Con.SetActive(true);
    }
    private void Start()
    {
        helmet.SetActive(true);
        armor.SetActive(false);
        shield.SetActive(false);
        shoe.SetActive(false);
        weapon.SetActive(false);
        Con.SetActive(false);
    }
}
