using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollect : MonoBehaviour
{
    //Döper om scriptet "WeaponSign" till "weaponsign"
    public WeaponSign weaponsign;

    // Update is called once per frame

    private void Start()
    {
        //sätter weaponsign till att den hittar scriptet "WeaponSign"
        weaponsign = FindObjectOfType<WeaponSign>();
    }
    //Om objectet nuddar
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Om man trycker E och det man nuddar är taggat med "Player" 
        if (Input.GetKeyDown(KeyCode.E) && (collision.tag == "Player"))
        {
            //Gameobjectet "signWeapon" hittas med taggen "Weapon" och sedan så är "weaponsign" = signweapon som får en WeaponSign
            GameObject signWeapon = GameObject.FindWithTag("Weapon");
            weaponsign = signWeapon.GetComponent<WeaponSign>();
            //Sätter vapnets rend till true så att man ser ett vapen vid spelaren (Man håller alltså i vapnet)
            weaponsign.rend.enabled = true;
            //Förstör sedan objectet som man plockade upp
            Destroy(gameObject);
        }




    }


}
